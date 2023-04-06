import { WhatsappLogo } from "@phosphor-icons/react";

export function ContactClinic() {
  return (
    <button className="border-[1px] border-solid border-[#999CA0] rounded-lg flex justify-center items-center gap-2 p-2 focus:ring active:transform active:translate-y-1">
      <WhatsappLogo size={20} />
      <p className="text-black not-italic font-normal text-sm">
        Enviar Whatsapp
      </p>
    </button>
  );
}
