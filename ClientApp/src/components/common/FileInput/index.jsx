import { Button } from "../Button";

export function FileInput({ className }) {
  return (
    <>
      <input
        type="file"
        className="absolute inset-0 w-full h-full opacity-0 cursor-pointer"
      />
      <Button
        className="w-32 h-8 border-gray-100 text-black text-sm"
        text="Elegir imagen"
      />
    </>
  );
}
