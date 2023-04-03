import { WhatsappLogo } from "@phosphor-icons/react";

export function ContactClinic() {
  return (
    <>
      <div className="mb-4 p-4">
        <button className="border-[1px] border-solid border-[#999CA0] rounded-lg flex justify-center items-center gap-2 p-2">
          <WhatsappLogo size={19} />
          Whatsapp
        </button>
      </div>
    </>
  );
}
