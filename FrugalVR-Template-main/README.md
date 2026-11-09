# FrugalVR-Template

<img width="400" height="400" alt="image" src="https://github.com/user-attachments/assets/a7f6e697-58b0-431a-b75e-1c0a83182455" />

## 1. Download the Project

1. Click the **Code** button.
3. Select **Download ZIP** and extract the downloaded archive.

## 2. Open the Project in Unity

1. Open **Unity Hub**.
2. Click **Add** → **Add project from disk**.
3. Select the extracted project folder.

If Unity Hub does not automatically detect the correct editor version, select **6000.4.0f1** and click **Open**.

> **Note:** If you need to install this Unity version, remember to include the **Android Build Support** module and its required components.

## 3. Wait for Unity

Wait for Unity to finish importing the project and preparing the workspace. This may take a while on the first launch.

## 4. Building for Android

Before making a build, remember to switch the **Build Profile** to **Android**.

All other build settings have already been configured, so you should be ready to build!

## Troubleshooting

- Unity might display errors related to DLL files or URP (Universal Render Pipeline). These can be ignored.
- **DO NOT delete any URP-related files or assets.**  Deleting these files will prevent the scene from building properly.
