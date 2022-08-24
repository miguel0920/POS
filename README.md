# Instalaciones requeridas

## Instalaciones:
* [Microsoft SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads).
* [Visual Studio](https://visualstudio.microsoft.com/es/).

## Scripts:
En Microsoft SQL Server correr el script que se encuentra en esta ruta "../scripts/create_database.sql".

Comando para ejecutar Scaffolding.
Desde visual abrir Administrador de paguetes en consola y seleccionar el proyecto POS.Domain.
``` 
Scaffold-DbContext "{Cadena de conexión}" Microsoft.EntityFrameworkCore.SqlServer OutputDir {carpeta donde se alojara}
```

Ejemplo para esta solución...

```
Scaffold-DbContext "Server=..;Trusted_Connection=True" Microsoft.EntityFrameworkCore.SqlServer OutputDir Entities
```

## License

MIT

**Free Software, Hell Yeah!**