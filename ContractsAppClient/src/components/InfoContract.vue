<template>
    <div v-if="contractInfo" class="mt-4">
      <h3 class="mb-4">Información del Contrato</h3>

      <div class="mb-4">
        <label class="mb-2">Código de curso:</label>
        <input type="text" v-model="contractInfo.data.courseCode" readonly class="form-control" />
      </div>
      <div class="mb-4">
        <label class="mb-2">Fecha de alta:</label>
        <input type="text" v-model="contractInfo.data.fechaAlta" readonly class="form-control" />
      </div>
      <div class="mb-4">
        <label class="mb-2">Colegio:</label>
        <input type="text" v-model="contractInfo.data.colegioNombre" readonly class="form-control" />
      </div>
      <div class="mb-4">
        <label class="mb-2">Nivel:</label>
        <input type="text" v-model="contractInfo.data.colegioNivel" readonly class="form-control" />
      </div>

      <div class="mb-4">
        <label class="mb-2">Curso:</label>
        <input type="text" v-model="contractInfo.data.colegioCurso" readonly class="form-control" />
      </div>
      <div class="mb-4">
        <label class="mb-2">Localidad:</label>
        <input type="text" v-model="contractInfo.data.colegioLocalidad" readonly class="form-control" />
      </div>

      <ItemsTable :items="contractInfo.data.items" :contractInfo="contractInfo" />
      
      <div class="mb-4">
        <label class="mb-2">Total:</label>
        <input type="text" v-model="contractInfo.data.total" readonly class="form-control" />
      </div>
      <div class="mb-4">
        <label class="mb-2">Fecha de entrega:</label>
        <input type="text" v-model="contractInfo.data.fechaEntrega" readonly class="form-control" />
      </div>
    </div>
  </template>
  
  <script>
  import ItemsTable from './ItemsTable.vue';
  
  export default {
    props: {
      contractInfo: Object,
    },
    components: {
      ItemsTable,
    },
  };
  </script>
  
  