import { Stethoscope } from "@phosphor-icons/react";
import { services } from "../../const/serviceClinic";
services;

export function ServiceClinic() {
  return (
    <div className="p-4 bg-white rounded-lg flex flex-col gap-2">
      <h2 className="text-[#010B1D] not-italic font-medium text-xl">
        Servicios ofrecidos
      </h2>
      <div className="grid grid-cols-1 gap-4">
        {services.map((service) => (
          <div key={service} className="flex justify-start items-center gap-2">
            <div className="bg-[#E0E0E0] p-1">
              <Stethoscope size={28} color="#666666" weight="bold" />
            </div>
            <p className="text-[#010B1D] not-italic font-normal text-base">
              {service}
            </p>
          </div>
        ))}
      </div>
      <div className="mt-2">
        <button className="border-[1px] border-solid border-[#999CA0] rounded-lg flex justify-center items-center p-2 pr-4 focus:ring active:transform active:translate-y-1">
          <p className="text-[#010B1D] not-italic font-normal text-sm">
            Mostrar los 13 servicios
          </p>
        </button>
      </div>
    </div>
  );
}
