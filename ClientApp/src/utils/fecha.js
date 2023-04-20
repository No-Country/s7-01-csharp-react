export function myFecha(mifecha) {
  const fecha = new Date(mifecha);

  const dia = fecha.getDate(); // Obtener el día
  const mes = fecha.getMonth() + 1; // Obtener el mes (+1 porque los meses en JavaScript son indexados desde 0)
  const anio = fecha.getFullYear(); // Obtener el año

  return `${dia}/${mes}/${anio}`;
}
