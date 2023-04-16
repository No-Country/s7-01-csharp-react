// hooks
import { useClinic } from "../../hooks/useClinic";
// components
import { CoverClinic } from "../../components/CoverClinic";
import { DataClinic } from "../../components/DataClinic";
import { ContactSocialNetwork } from "../../components/common";
import { InfoClinic } from "../../components/InfoClinic";
import { ServiceClinic } from "../../components/ServiceClinic";
import Navbar from "../../components/Layouts/Navbar";
import { SocialNetwork } from "../../components/SocialNetwork";
import { OtherClinic } from "../../components/OtherClinic";

// icons
import { WhatsappLogo } from "@phosphor-icons/react";

export function Clinic() {
  const { clinic } = useClinic();

  console.log(clinic);

  return (
    <>
      <header>
        <Navbar />
      </header>

      <main className="flex flex-col gap-8">
        <section className="container relative mx-auto">
          <CoverClinic />
        </section>

        <section className="mt-10 mx-4">
          <DataClinic />
        </section>

        <section className="mx-4">
          <ContactSocialNetwork
            icon={<WhatsappLogo size={20} />}
            title="Enviar Whatsapp"
          />
        </section>

        <section className="mx-4">
          <InfoClinic />
        </section>

        <section className="mx-4">
          <ServiceClinic />
        </section>

        <section className="mx-4">
          <SocialNetwork />
        </section>

        <section className="mx-4">
          <OtherClinic />
        </section>
      </main>
    </>
  );
}
