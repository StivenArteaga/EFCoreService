General: Este proyecto es una pequeña muestra de ejemplo de como realizar una migración con EFCore

Precondición: Seleccionar en la consola de administrador de paquetes la capa que cuenta con la carpeta Migrations

Comandos: 
	add-migration : agregar una nueva migración.
	update-database : crea o actualiza la base de datos a la última migración o una migración específica.
	remove-migration : elimina la última migración (revierte los cambios de código que se realizaron para la migración).

	bundle-migration : crea un ejecutable para actualizar la base de datos.
	drop-database : elimina la base de datos
	get-dbcontext : enumera y obtiene información sobre los DbContext tipos disponibles.
	get-migration : enumera las migraciones disponibles. Agregado en EF Core 5.0.
	optimize-dbcontext : genera una versión compilada del modelo utilizado por DbContext. Agregado en EF Core 6.
	scaffold-dbcontext : genera código para un DbContexttipo de entidad y para una base de datos. Para Scaffold-DbContextgenerar un tipo de entidad, la tabla de la base de datos debe tener una clave principal.
	script-dbcontext : genera un script SQL a partir de DbContext. Omite cualquier migración.
	script-migration : genera un script SQL que aplica todos los cambios de una migración seleccionada a otra migración seleccionada

