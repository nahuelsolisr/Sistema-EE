# 📊 SistemaEE - Gestión Económica Empresarial

SistemaEE es un sistema diseñado para **gestionar inventarios, ventas, compras y administración de clientes/proveedores** en **pequeñas empresas**.

## 🚀 Propósito y Alcance
Este sistema facilita la administración empresarial mediante:
- **📦 Control de inventario** con alertas de stock bajo.
- **💰 Procesamiento de transacciones** para compras y ventas.
- **📑 Gestión de clientes y proveedores** con seguimiento de relaciones comerciales.
- **🔒 Seguridad y administración de usuarios** con acceso controlado.

## 🏗️ Arquitectura del Sistema
SistemaEE emplea una **arquitectura de tres capas**:
1. **🔹 Presentación:** UI basada en Windows Forms con diseño MaterialSkin.
2. **🔹 Lógica de negocio:** Procesos de validación, filtrado y gestión de datos.
3. **🔹 Acceso a datos:** SQL Server como base de datos.

## 📜 Componentes principales
| Módulo | Propósito |
|--------|----------|
| `Login.cs` | Autenticación de usuarios |
| `Menu.cs` | Navegación central del sistema |
| `Clientes.cs` | Administración de clientes |
| `Productos.cs` | Gestión de productos |
| `Proveedores.cs` | Registro de proveedores |
| `Entrada.cs` | Registro de compras |
| `Salidas.cs` | Registro de ventas |
| `FichaDeStock.cs` | Seguimiento detallado del inventario |


## 🎨 Interfaz de Usuario
SistemaEE utiliza **MaterialSkin** para una experiencia visual moderna:
- **Modo claro/oscuro** para personalización.
- **Navegación basada en formularios** intuitivos.
- **Filtros de búsqueda avanzados** en listas de datos.
