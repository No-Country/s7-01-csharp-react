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

  console.log(
    "🚀 ~ file: index.jsx:31 ~ Clinic ~ clinic.logoUri:",
    clinic.logoURI
  );

  return (
    <>
      <header>
        <Navbar />
      </header>

      <main className="my-4 mx-4 grid grid-cols-1 gap-8 lg:grid-cols-3 lg:container lg:mx-auto lg:mt-6">
        <section className="flex flex-col gap-8 lg:col-span-2">
          <article className="relative">
            <CoverClinic logo={clinic.logoURI} />
            <div className="bg-white pt-20 p-4 rounded-b-lg border-0">
              <DataClinic name={clinic.nombre} />
              <ContactSocialNetwork
                icon={<WhatsappLogo size={20} />}
                title="Enviar Whatsapp"
              />
            </div>
          </article>
          <article>
            <InfoClinic />
          </article>
          <article>
            <ServiceClinic />
          </article>
          <article>
            <SocialNetwork />
          </article>
        </section>

        <aside className="lg:col-span-1">
          <OtherClinic />
        </aside>
      </main>
    </>
  );
}
