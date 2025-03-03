# Temporary Folder Creator

一个简单的 C# 控制台应用程序，用于自动创建按日期组织的临时文件夹结构，并自动打开当日文件夹。

## 功能特性

- 🗂️ 自动在 D 盘创建根目录 `D:\Temporary`
- 📅 按年月（yyMM 格式）创建一级子目录
- 📆 按日（dd 格式）创建二级子目录
- 🖱️ 自动打开当日的资源管理器窗口
- ✅ 自动检测并跳过已存在的目录

## 使用方法

### 直接运行

1. 下载 Release 中的可执行文件
2. 双击运行 `TemporaryFolder.exe`
3. 自动打开当天的目录：`D:\Temporary\yyMM\dd`

### 从源代码运行

1. 克隆本仓库
2. 使用 Visual Studio 打开解决方案
3. 编译并运行项目

## 注意事项

- 需要 .NET Framework 4.7.2 或更高版本
- 请确保 D 盘有写入权限
- 路径格式默认使用 Windows 风格的反斜杠（\）
- 程序会在首次运行时创建完整的目录结构

## 自定义设置

可修改以下代码段实现自定义配置：

```csharp
// 修改根目录路径
var tmp_dir = "D:\\Temporary";

// 修改日期格式（当前为 年月 → yyMM，日 → dd）
string fold_1 = now.ToString("yyMM");
string fold_2 = now.ToString("dd");
```
