// components
import { DataClinic } from "../DataClinic";
import { ContactSocialNetwork } from "../common";

// icons
import { WhatsappLogo } from "@phosphor-icons/react";

export function OtherClinic() {
  return (
    <>
      <div className="p-4 border-[1px] border-solid border-[#999CA0] rounded-lg flex flex-col gap-2">
        <h2 className="text-[#010B1D] not-italic font-medium text-xl">
          Otras clinicas cercanas
        </h2>
        <div className="flex flex-row justify-center gap-4">
          <div className="w-12 h-12 rounded-full bg-slate-500">
            <img
              className="w-full h-full rounded-full object-cover object-center"
              src="https://picsum.photos/200/300?random=1"
              alt="perfil"
            />
          </div>
          <div className="flex flex-col">
            <DataClinic />
            <ContactSocialNetwork
              icon={<WhatsappLogo size={20} />}
              title="Enviar Whatsapp"
            />
          </div>
        </div>
        <hr className="border border-solid border-[#EBEBEB]" />
      </div>
    </>
  );
}