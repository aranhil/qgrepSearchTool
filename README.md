# qgrep GUI

*qgrep GUI* is a Visual Studio extension and GUI wrapper for [qgrep](https://github.com/zeux/qgrep) by Arseny Kapoulkine. As an indexing search tool, it's well-suited for large codebases, providing a user-friendly and responsive interface equipped with all standard search tool features. Additionally, it offers fully customizable color themes for a more personalized user experience.

![Animation](https://github.com/aranhil/qgrepGUI/assets/755601/05eecff9-d7eb-4beb-95fa-1cf7a0b8c2ea)

## Installation

Install the Visual Studio extension and follow the setup instructions below.

## Setting up in Visual Studio

1. After installing the extension, the toolbar can be opened from **View >> Other Windows >> qgrep Search Tool**. It also comes with a shorcut already assigned (Alt+Shift+F), but if it's already assigned or you want to change it, you can do that from **Tools >> Options >> Environment >> Keyboard** and the command name is "View.qgrepSearchTool".

2. After this, you have to set up the folders that will be indexed. The window for this can be opened up from the lower left corner of the toolbar:

   ![image](https://user-images.githubusercontent.com/755601/236962201-40373b1a-f74c-4fe9-8cd2-4fbb70417c8d.png)

3. From here, you can add the folders and file filters. The "Gather from solution" button will automatically grab all the folders inside your solution. You can also select multiple folders at once.

   ![image](https://user-images.githubusercontent.com/755601/236962315-6a4029f9-7cb7-429c-9237-b546d9a97ba3.png)

4. After closing this window, indexing will begin automatically, and you can start searching.

## Interface overview

![image](https://user-images.githubusercontent.com/755601/236962874-6614cf8c-dcf8-4029-8dce-fc8f323409f3.png)

### Search input

The search input has three toggles that can also be found in Visual Studio: Case sensitive, Whole word, and Regular expressions.

### Search results

The search results list can be interacted with the keyboard/mouse without the search input losing the focus. There is also a contextual menu with more options:

   ![image](https://user-images.githubusercontent.com/755601/236962612-82f1e2a6-2001-4016-8c22-f6532a562113.png)

### Customize colors

Here you can switch between the Auto, Dark, and Light color schemes. If you're in Visual Studio, the Auto color scheme grabs the IDE's colors automatically, so you can use any custom theme you want:

   ![ezgif com-optimize](https://user-images.githubusercontent.com/755601/236553098-99c9d092-fa59-4d53-8365-fa01469f605b.gif)

You also have the option to override any color used in the currently selected color scheme.

### Advanced options

- **Include files**: Toggles the visibility of an input textbox that you can use to match the files that will be searched.
- **Exclude files**: Like the previous one, but this one excludes the matched files from the search.
- **Filter results**: Like the previous two, can be used to further filter the results, for both the path and the text
- **Show history**: This toggles the visibility of an icon on the input search box that shows all your recent searches.
- **Search while typing**: This will be on by default, but if you have performance issues, you can turn it off. Note that turning this off will no longer always keep the focus of the input textbox.
- **Group by**: File - groups the results by file; None - shows the results on a single line
- **Group expand**:If the previous option is set to File, this chooses how group expansion will be handled. Auto collapses all the results if there are too many.
- **Path style**: This changes how the paths will be shown in the results, it does NOT affect searching.
- **Trim spaces on copy**: This will trim any spaces and tabs surrounding the text when it's being copied.

### Search configurations

Advanced mode opens up the possibility to toggle between multiple search configs. After setting them up, they can then be switched on or off from the lower left corner of the toolbar.

   ![image](https://user-images.githubusercontent.com/755601/236962730-bd60a100-1697-4438-ad31-4590848d21bf.png)

### Update cache

This button updates the index.

### Clean and update cache

If there is an error with the indexing, this button cleans everything and indexes from scratch.

## License

*qgrep Search Tool* is licensed under the [MIT License](LICENSE).

## Support

If you have any questions or need help, please open an issue in the [GitHub repository](https://github.com/aranhil/qgrepSearchTool/issues).

## Acknowledgements

This project has benefited from the use of the following open-source projects:

- [qgrep](https://github.com/zeux/qgrep): This project is licensed under the [MIT License](./LICENSE-qgrep.md).
- [Extended WPF Toolkit™](https://github.com/xceedsoftware/wpftoolkit): This project has been used for the color picker and the CheckComboBox. The version used (3.8.2) is licensed under the [MS-PL license](./LICENSE-Extended-WPF-Toolkit.md).
- [ControlzEx](https://github.com/ControlzEx/ControlzEx): This project has been used to replace the standard Windows title bar. It is licensed under the [MIT License](./LICENSE-ControlzEx.md).

This project also makes use of icons from [Visual Studio Code - Icons](https://github.com/microsoft/vscode-icons), which are used under the terms of the [Creative Commons Attribution 4.0 International License](./LICENSE-vscode-icons.md).
