// This is the main DLL file.

#include "stdafx.h"

#include "WPDInterfacing.h"

void WPDInterfacing::TestInterfacing::enumerateWPDDevices() {
    DWORD                           pnpDeviceIDCount = 0;
    ComPtr<IPortableDeviceManager>  deviceManager;

    // CoCreate the IPortableDeviceManager interface to enumerate
    // portable devices and to get information about them.
    //<SnippetDeviceEnum1>
    HRESULT hr = CoCreateInstance(CLSID_PortableDeviceManager,
        nullptr,
        CLSCTX_INPROC_SERVER,
        IID_PPV_ARGS(&deviceManager));
    if (FAILED(hr)) {
        wprintf(L"! Failed to CoCreateInstance CLSID_PortableDeviceManager, hr = 0x%lx\n", hr);
    }
    //</SnippetDeviceEnum1>

    // 1) Pass nullptr as the PWSTR array pointer to get the total number
    // of devices found on the system.
    //<SnippetDeviceEnum2>
    if (SUCCEEDED(hr)) {
        hr = deviceManager->GetDevices(nullptr, &pnpDeviceIDCount);
        if (FAILED(hr)) {
            wprintf(L"! Failed to get number of devices on the system, hr = 0x%lx\n", hr);
        }
    }

    // Report the number of devices found.  NOTE: we will report 0, if an error
    // occured.

    wprintf(L"\n%u Windows Portable Device(s) found on the system\n\n", pnpDeviceIDCount);
    //</SnippetDeviceEnum2>
    // 2) Allocate an array to hold the PnPDeviceID strings returned from
    // the IPortableDeviceManager::GetDevices method
    //<SnippetDeviceEnum3>
    if (SUCCEEDED(hr) && (pnpDeviceIDCount > 0)) {
        PWSTR* pnpDeviceIDs = new (std::nothrow) PWSTR[pnpDeviceIDCount];
        if (pnpDeviceIDs != nullptr) {
            ZeroMemory(pnpDeviceIDs, pnpDeviceIDCount * sizeof(PWSTR));
            DWORD retrievedDeviceIDCount = pnpDeviceIDCount;
            hr = deviceManager->GetDevices(pnpDeviceIDs, &retrievedDeviceIDCount);
            if (SUCCEEDED(hr)) {
                _Analysis_assume_(retrievedDeviceIDCount <= pnpDeviceIDCount);
                // For each device found, display the devices friendly name,
                // manufacturer, and description strings.
                for (DWORD index = 0; index < retrievedDeviceIDCount; index++) {
                    wprintf(L"[%u] ", index);
                    DisplayFriendlyName(deviceManager.Get(), pnpDeviceIDs[index]);
                    wprintf(L"    ");
                    DisplayManufacturer(deviceManager.Get(), pnpDeviceIDs[index]);
                    wprintf(L"    ");
                    DisplayDescription(deviceManager.Get(), pnpDeviceIDs[index]);
                }
            } else {
                wprintf(L"! Failed to get the device list from the system, hr = 0x%lx\n", hr);
            }
            //</SnippetDeviceEnum3>

            // Free all returned PnPDeviceID strings by using CoTaskMemFree.
            // NOTE: CoTaskMemFree can handle nullptr pointers, so no nullptr
            //       check is needed.
            for (DWORD index = 0; index < pnpDeviceIDCount; index++) {
                CoTaskMemFree(pnpDeviceIDs[index]);
                pnpDeviceIDs[index] = nullptr;
            }

            // Delete the array of PWSTR pointers
            delete[] pnpDeviceIDs;
            pnpDeviceIDs = nullptr;
        } else {
            wprintf(L"! Failed to allocate memory for PWSTR array\n");
        }
    }

}

    //</SnippetDeviceEnum6>
    // Reads and displays the device friendly name for the specified PnPDeviceID string
    void DisplayFriendlyName(
        _In_ IPortableDeviceManager* deviceManager,
        _In_ PCWSTR                  pnpDeviceID) {
        DWORD friendlyNameLength = 0;

        // 1) Pass nullptr as the PWSTR return string parameter to get the total number
        // of characters to allocate for the string value.
        HRESULT hr = deviceManager->GetDeviceFriendlyName(pnpDeviceID, nullptr, &friendlyNameLength);
        if (FAILED(hr)) {
            wprintf(L"! Failed to get number of characters for device friendly name, hr = 0x%lx\n", hr);
        } else if (friendlyNameLength > 0) {
            // 2) Allocate the number of characters needed and retrieve the string value.
            PWSTR friendlyName = new (std::nothrow) WCHAR[friendlyNameLength];
            if (friendlyName != nullptr) {
                ZeroMemory(friendlyName, friendlyNameLength * sizeof(WCHAR));
                hr = deviceManager->GetDeviceFriendlyName(pnpDeviceID, friendlyName, &friendlyNameLength);
                if (SUCCEEDED(hr)) {
                    wprintf(L"Friendly Name: %ws\n", friendlyName);
                } else {
                    wprintf(L"! Failed to get device friendly name, hr = 0x%lx\n", hr);
                }

                // Delete the allocated friendly name string
                delete[] friendlyName;
                friendlyName = nullptr;
            } else {
                wprintf(L"! Failed to allocate memory for the device friendly name string\n");
            }
        } else {
            wprintf(L"The device did not provide a friendly name.\n");
        }
    }

    // Reads and displays the device manufacturer for the specified PnPDeviceID string
    void DisplayManufacturer(
        _In_ IPortableDeviceManager* deviceManager,
        _In_ PCWSTR                  pnpDeviceID) {
        DWORD manufacturerLength = 0;

        // 1) Pass nullptr as the PWSTR return string parameter to get the total number
        // of characters to allocate for the string value.
        HRESULT hr = deviceManager->GetDeviceManufacturer(pnpDeviceID, nullptr, &manufacturerLength);
        if (FAILED(hr)) {
            wprintf(L"! Failed to get number of characters for device manufacturer, hr = 0x%lx\n", hr);
        } else if (manufacturerLength > 0) {
            // 2) Allocate the number of characters needed and retrieve the string value.
            PWSTR manufacturer = new (std::nothrow) WCHAR[manufacturerLength];
            if (manufacturer != nullptr) {
                ZeroMemory(manufacturer, manufacturerLength * sizeof(WCHAR));
                hr = deviceManager->GetDeviceManufacturer(pnpDeviceID, manufacturer, &manufacturerLength);
                if (SUCCEEDED(hr)) {
                    wprintf(L"Manufacturer:  %ws\n", manufacturer);
                } else {
                    wprintf(L"! Failed to get device manufacturer, hr = 0x%lx\n", hr);
                }

                // Delete the allocated manufacturer string
                delete[] manufacturer;
                manufacturer = nullptr;
            } else {
                wprintf(L"! Failed to allocate memory for the device manufacturer string\n");
            }
        } else {
            wprintf(L"The device did not provide a manufacturer.\n");
        }
    }

    // Reads and displays the device discription for the specified PnPDeviceID string
    void DisplayDescription(
        _In_ IPortableDeviceManager* deviceManager,
        _In_ PCWSTR                  pnpDeviceID) {
        DWORD descriptionLength = 0;

        // 1) Pass nullptr as the PWSTR return string parameter to get the total number
        // of characters to allocate for the string value.
        HRESULT hr = deviceManager->GetDeviceDescription(pnpDeviceID, nullptr, &descriptionLength);
        if (FAILED(hr)) {
            wprintf(L"! Failed to get number of characters for device description, hr = 0x%lx\n", hr);
        } else if (descriptionLength > 0) {
            // 2) Allocate the number of characters needed and retrieve the string value.
            PWSTR description = new (std::nothrow) WCHAR[descriptionLength];
            if (description != nullptr) {
                ZeroMemory(description, descriptionLength * sizeof(WCHAR));
                hr = deviceManager->GetDeviceDescription(pnpDeviceID, description, &descriptionLength);
                if (SUCCEEDED(hr)) {
                    wprintf(L"Description:   %ws\n", description);
                } else {
                    wprintf(L"! Failed to get device description, hr = 0x%lx\n", hr);
                }

                // Delete the allocated description string
                delete[] description;
                description = nullptr;
            } else {
                wprintf(L"! Failed to allocate memory for the device description string\n");
            }
        } else {
            wprintf(L"The device did not provide a description.\n");
        }
    }
