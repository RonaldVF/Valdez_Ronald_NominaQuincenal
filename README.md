# Nómina Quincenal

## Nombre y matrícula
- Nombre: Ronald Valdez Francisco
- Matrícula: 2025-1402

## Descripción
Aplicación de Windows Forms en C# para calcular el pago quincenal de empleados, validar los datos ingresados, registrar cada pago en una lista y mostrar los totales acumulados de la nómina.

## Datos de entrada
- Nombre del empleado (`txtEmpleado`).
- Tipo de contrato (`rdbFijo` o `rdbTemporal`).
- Cargo (`cmbCargo`): Auxiliar (RD$ 180/h), Técnico (RD$ 250/h), Supervisor (RD$ 350/h) o Gerente (RD$ 500/h).
- Horas trabajadas en la quincena del 1 al 120 (`txtHoras`).
- Incentivo de transporte de RD$ 1,500 (`chkTransporte`).

## Proceso
1. Al cargar (`Load`), se cargan los cargos en el `ComboBox`, se marca el contrato fijo por defecto y se limpian las etiquetas del resumen.
2. Al registrar empleado (`btnRegistrar`), se validan los campos, se calcula el salario regular (hasta 88 horas), las horas extra con 35% adicional, el incentivo de transporte y las deducciones de AFP (2.87%) y SFS (3.04%) solo si el contrato es Fijo.
3. El pago neto se agrega a la lista (`lstNomina`) y se actualizan los acumuladores a nivel de formulario.
4. Mostrar resumen (`btnResumen`) verifica que haya al menos un empleado registrado y presenta la cantidad de empleados y los totales acumulados en formato RD$ con dos decimales.
5. Limpiar (`btnLimpiar`) restablece los controles de entrada a su estado inicial sin borrar los registros acumulados.
6. Salir (`btnSalir`) cierra la aplicación.

## Salida
- Lista de empleados registrados en `lstNomina` con nombre, cargo y pago neto (`RD$ 0.00`).
- Etiquetas de resumen (`lblEmpleados`, `lblBruto`, `lblDeducciones` y `lblNeto`) con la cantidad de empleados y los totales formateados en `RD$` con dos decimales.

## Capturas de pantalla
<img width="800" height="547" alt="image" src="https://github.com/user-attachments/assets/d1f6240e-6956-4d1f-a10f-2eb74b00852f" />
<img width="792" height="537" alt="image" src="https://github.com/user-attachments/assets/43af9043-a9a5-4752-9eb3-925dec8c975d" />

