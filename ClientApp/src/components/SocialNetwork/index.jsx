import {
  GlobeSimple,
  FacebookLogo,
  InstagramLogo,
} from "@phosphor-icons/react";

export function SocialNetwork() {
  return (
    <section className="mx-4">
      <div className="p-4 border-[1px] border-solid border-[#999CA0] rounded-lg flex flex-col gap-2 overflow-hidden">
        <h2 className="text-[#010B1D] not-italic font-medium text-xl">
          Síguenos
        </h2>
        <div className="flex flex-row gap-2">
          <button className="border-[1px] border-solid border-[#999CA0] rounded-lg flex justify-center items-center gap-2 p-2 px-4 focus:ring active:transform active:translate-y-1">
            <GlobeSimple size={20} color="#474747" weight="bold" />
            <p className="text-black not-italic font-normal text-sm">Website</p>
          </button>
          <button className="border-[1px] border-solid border-[#999CA0] rounded-lg flex justify-center items-center gap-2 p-2 focus:ring active:transform active:translate-y-1">
            <FacebookLogo size={20} color="#474747" weight="bold" />
            <p className="text-black not-italic font-normal text-sm">
              Facebook
            </p>
          </button>
          <button className="border-[1px] border-solid border-[#999CA0] rounded-lg flex justify-center items-center gap-2 p-2 focus:ring active:transform active:translate-y-1">
            <InstagramLogo size={20} color="#474747" weight="bold" />
            <p className="text-black not-italic font-normal text-sm">
              Instagram
            </p>
          </button>
        </div>
      </div>
    </section>
  );
}
