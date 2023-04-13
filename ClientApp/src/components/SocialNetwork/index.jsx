import {
  GlobeSimple,
  FacebookLogo,
  InstagramLogo,
} from "@phosphor-icons/react";

import { ContactSocialNetwork } from "../common";

export function SocialNetwork() {
  return (
    <div className="p-4 border-[1px] border-solid border-[#999CA0] rounded-lg flex flex-col gap-2 overflow-hidden">
      <h2 className="text-[#010B1D] not-italic font-medium text-xl">
        Síguenos
      </h2>
      <div className="flex flex-row gap-2">
        <ContactSocialNetwork
          className="px-5 w-36"
          icon={<GlobeSimple size={20} color="#474747" weight="bold" />}
          title="Website"
        />
        <ContactSocialNetwork
          className="px-5 w-36"
          icon={<GlobeSimple size={20} color="#474747" weight="bold" />}
          title="Facebook"
        />
        <ContactSocialNetwork
          className="px-5 w-36"
          icon={<GlobeSimple size={20} color="#474747" weight="bold" />}
          title="Instagram"
        />
      </div>
    </div>
  );
}
