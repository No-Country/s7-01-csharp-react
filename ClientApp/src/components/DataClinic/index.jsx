import { Clock, MapPin } from "@phosphor-icons/react";

export function DataClinic() {
  return (
    <>
      <section className="mt-10 mx-4">
        <div className="mb-2">
          <h1 className="text-[#010B1D] not-italic font-medium text-2xl">
            nombre de la clinica
          </h1>
        </div>

        <div className="flex justify-start items-center gap-1.5 mb-2 text-sm text-[#888888]">
          <Clock className="block" size={13} />
          <p className="text-[#888888] not-italic font-normal text-xs uppercase">
            LUN. A VIE. DE 08:00 A 19:00
          </p>
        </div>
        <div className="flex justify-start items-center gap-1.5 mb-2 text-sm text-[#888888]">
          <MapPin size={13} />
          <p className="text-[#888888] not-italic font-normal text-xs uppercase">
            dirección
          </p>
        </div>
      </section>
    </>
  );
}
