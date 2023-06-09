import { FileInput } from "../common";

export function ContentImage({ content }) {
  return (
    <div className="bg-white mt-2 px-4 py-3 border border-dashed border-gray-50 rounded-lg flex flex-col items-start justify-center gap-2">
      <div className="flex flex-row justify-center items-center gap-2">
        <div className="w-8 h-8">
          <img
            className="w-full h-full object-cover object-center"
            src="https://picsum.photos/200/300?random=1"
            alt="preview"
          />
        </div>
        <p className="text-[#888888] not-italic font-normal text-sm">
          Agrega una imagen de tu mascota.
        </p>
      </div>
      <div className="relative self-center">
        <FileInput />
      </div>
    </div>
  );
}
