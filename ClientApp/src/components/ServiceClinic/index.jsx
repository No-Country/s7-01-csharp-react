import { Stethoscope } from "@phosphor-icons/react";
import { services } from "../../const/serviceClinic";
services;

export function ServiceClinic() {
  return (
    <>
      <section className="mx-4">
        <div className="p-4 border-[1px] border-solid border-[#999CA0] rounded-lg flex flex-col gap-2">
          <h2 className="text-black not-italic font-medium text-xl">
            Servicios ofrecidos
          </h2>
          <div class="grid grid-cols-1 gap-4">
            {services.map((service) => (
              <div
                key={service}
                className="flex justify-start items-center gap-2"
              >
                <div className="bg-[#E0E0E0] p-1">
                  <Stethoscope size={28} color="#666666" weight="bold" />
                </div>
                <p>{service}</p>
              </div>
            ))}
          </div>
          <div className="mt-2">
            <button className="border-[1px] border-solid border-[#999CA0] rounded-lg flex justify-center items-center p-2 pr-4">
              Mostrar los 13 servicios
            </button>
          </div>
        </div>
      </section>
    </>
  );
}
