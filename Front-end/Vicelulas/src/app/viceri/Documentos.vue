<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center>
      <v-flex md6 xs12>
        <v-card dark>
          <v-treeview
          v-model="tree"
          :open="open"
          :items="items"
          activatable
          item-key="name"
          open-on-click
        >
          <template slot="prepend" slot-scope="{ item, open }">
            <v-icon v-if="!item.file">
              {{ open ? 'mdi-folder-open' : 'mdi-folder' }}
            </v-icon>
            <v-icon v-else>
              {{ files[item.file] }}
            </v-icon>
          </template>
        </v-treeview>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Documentos',
  data: () => ({
    open: ['public'],
    files: {
      html: 'mdi-language-html5',
      js: 'mdi-nodejs',
      md: 'mdi-markdown',
      doc: 'mdi-file-word',
      ppt: 'mdi-file-powerpoint',
      xls: 'mdi-file-excel',
      pdf: 'mdi-file-pdf',
      png: 'mdi-file-image',
      txt: 'mdi-file-document-outline'
    },
    tree: [],
    items: [
      {
        name: '1. Sobre o Grupo Viceri e Handbook',
        children: [
          { name: 'Handbook do Profissional', file: 'doc', to: '' },
          { name: 'Manual da Organização', file: 'ppt', to: '' }
        ]
      },
      {
        name: '2. Gerenciamento de Performance e Desenvolvimento Profissional',
        children: [
          {
            name: 'Artigos, eBooks, Apresentações, outros...',
            children: [
              {
                name: 'Artigos Harvard Business Review',
                children: [
                  { name: 'Coaching Employees', file: 'pdf', to: '' },
                  { name: 'Merotocracy Case 1', file: 'pdf', to: '' },
                  { name: 'Merotocracy Case', file: 'pdf', to: '' }
                ]
              },
              {
                name: 'Artigos SHRM',
                children: [
                  { name: 'Cost Of Bad Hire', file: 'pdf', to: '' },
                  { name: 'Employee Performance Management App', file: 'pdf', to: '' }
                ]
              },
              {
                name: 'Artigos Tower Watson - Muito bons',
                children: [
                  { name: 'Developing Leadership Talent', file: 'pdf', to: '' },
                  { name: 'How to Establish a Performance Improvement Plan', file: 'pdf', to: '' },
                  { name: 'Human Capital Strategy - Willis Towers Watson', file: 'pdf', to: '' },
                  { name: 'Introduction to the Discipline of Human Resources Technology', file: 'pdf', to: '' },
                  { name: 'Leveraging the Value of Employee Self-Service Portals', file: 'pdf', to: '' },
                  { name: 'Pay For Performance Time To Challenge Conventional Thinking - Willis Towers Watson', file: 'pdf', to: '' },
                  { name: 'Performance Management', file: 'pdf', to: '' },
                  { name: 'Setting Goals And Objectives Training', file: 'ppt', to: '' },
                  { name: 'Viewpoints QA Technology Helps Employers Transform Performance Management', file: 'ppt', to: '' },
                  { name: 'Viewpoints QA The New Human Capital Framework - Willis Towers Watson (0)', file: 'pdf', to: '' },
                  { name: 'Viewpoints QA The New Human Capital Framework - Willis Towers Watson (1)', file: 'pdf', to: '' },
                  { name: 'Viewpoints QA The New Human Capital Framework - Willis Towers Watson (2)', file: 'pdf', to: '' },
                  { name: 'WTW Viewpoints QA Human Capital Framework Part 2', file: 'pdf', to: '' },
                  { name: 'WTW Viewpoints QA Human Capital Framework Part 3', file: 'pdf', to: '' },
                  { name: 'WTW Viewpoints QA Human Capital Framework Part 4', file: 'pdf', to: '' },
                  { name: 'WTW Viewpoints QA Performance Management', file: 'pdf', to: '' }
                ]
              },
              {
                name: 'Meritocracia',
                children: [
                  { name: 'Meritocracia - Luis Roberto Barroso Brasil e Meritocracia', file: 'pdf', to: '' }
                ]
              },
              {
                name: 'OKR - Motivação 3.0 e FLOW',
                children: [
                  { name: 'Effective Goal Alignment and Management', file: 'pdf', to: '' },
                  { name: 'Motivação 3.0 - Aspectos Principais', file: 'pdf', to: '' }
                ]
              }
            ]
          },
          { name: 'Manual OKR', file: 'doc', to: '' },
          { name: 'Manual Personal OKR', file: 'xls', to: '' },
          { name: 'Manual Talentos Sucessão e Postos Críticos', file: 'ppt', to: '' },
          { name: 'Mapa Talentos Sucessão e Postos Críticos', file: 'xls', to: '' }
        ]
      },
      {
        name: '3. Sua Carreira',
        children: [
          {
            name: 'Certificações',
            children: [
              { name: 'Certificações Técnicas', file: 'pdf' }
            ]
          },
          {
            name: 'Descrição de Cargos',
            children: [
              { name: 'Analista Adm Financeiro', file: 'xls' },
              { name: 'Analista ALM', file: 'xls' },
              { name: 'Analista de Infraestrutura', file: 'xls' },
              { name: 'Analista de Marketing e Comercial', file: 'xls' },
              { name: 'Analista de Negócios', file: 'xls' },
              { name: 'Analista de Qualidade', file: 'xls' },
              { name: 'Analista de RH', file: 'xls' },
              { name: 'Analista de Sistemas', file: 'xls' },
              { name: 'Analista Programador Mobile', file: 'xls' },
              { name: 'Analista Programador - Sustentação', file: 'xls' },
              { name: 'Analista Programador', file: 'xls' },
              { name: 'Arquiteto de Software', file: 'xls' },
              { name: 'Consultor ALM', file: 'xls' },
              { name: 'Coordenador de Desenvolvimento de Sistemas', file: 'xls' },
              { name: 'Coordenador de Sustentação de Sistemas', file: 'xls' },
              { name: 'Estagiário de Programação', file: 'xls' },
              { name: 'Estágio de RH', file: 'xls' },
              { name: 'Gerente TI', file: 'xls' },
              { name: 'Programador', file: 'xls' },
              { name: 'Web Designer', file: 'xls' }
            ]
          },
          {
            name: 'Trilha de Carreira',
            children: [
              { name: 'Trilha de Carreira - Operação', file: 'png' },
              { name: 'Trilha de Carreira - Recursos Humanos', file: 'png' }
            ]
          }
        ]
      },
      {
        name: '4. Políticas Corporativas',
        children: [
          { name: 'Política de Growth  and Learning', file: 'doc' },
          { name: 'Política de Viagem', file: 'doc' },
          { name: 'Política e Procedimento Utilização do Veículo Oficial', file: 'doc' },
          { name: 'Política e Procedimentos de Compras', file: 'doc' }
        ]
      }
    ]
  })
}
</script>
