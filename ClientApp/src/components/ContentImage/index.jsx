import { Button } from "../common";

export function ContentImage({ content }) {
  return (
    <div className="bg-white mt-2 px-4 py-3 border border-dashed border-gray-50 rounded-lg flex flex-col gap-2 content-center items-center">
      <div className="flex flex-row content-center items-center gap-2">
        <div className="bg-gray-50 w-8 h-8"></div>
        <p className="text-[#888888] not-italic font-normal text-sm">
          Agrega una imagen de tu mascota
        </p>
      </div>
      <Button className="w-32 h-8" text="Elegir imagen" />
    </div>
  );
}
