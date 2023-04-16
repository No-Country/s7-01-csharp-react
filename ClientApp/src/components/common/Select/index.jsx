export function Select({ className }) {
  return (
    <select className="border rounded-lg w-full py-2 px-3 text-gray-100 bg-white focus:outline-none focus:border-blue-500">
      <option value="">Elegir</option>
      <option value="opcion1">Perro</option>
      <option value="opcion2">Gato</option>
      <option value="opcion3">Ave</option>
      <option value="opcion4">Roedor</option>
      <option value="opcion4">Reptil</option>
      <option value="opcion5">Otro</option>
    </select>
  );
}
