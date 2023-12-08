<template>
    <div class="mb-5 mt-5">
      <h4>Pedidos</h4>
      <div class="tableItems">
        <div class="item-container item-header">
          <div class="item-column">
            <strong>Cantidad</strong>
          </div>
          <div class="item-column">
            <strong>Artículo</strong>
          </div>
          <div class="item-column">
            <strong>Precio unitario</strong>
          </div>
          <div class="item-column">
            <strong>Total</strong>
          </div>
        </div>
  
        <div v-for="item in items" :key="item.id" class="item-container">
          <div class="item-column">
            <input type="text" v-model="$props.contractInfo.data.cantidadEgresados" readonly class="form-control" />
          </div>
          <div class="item-column">
            <input type="text" v-model="item.nombre" readonly class="form-control" />
          </div>
          <div class="item-column">
            <input type="text" v-model="item.precio" readonly class="form-control" />
          </div>
          <div class="item-column">
            <label type="text" v-text="item.precio * $props.contractInfo.data.cantidadEgresados" readonly class="form-control"></label>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>

  export default {
    props: {
      items: Array,
      contractInfo: Object,
    },
  };
  </script>
  
  <style scoped>
.item-column {
  flex: 1;
  margin-right: 10px;
}
.item-header {
  background-color: #95c8f7;
}
.tableItems {
  width: 100%;
}
.item-container {
  display: flex;
  margin-bottom: 10px;
  border-bottom: 1px solid #ccc;
  padding: 10px;
}

@media (max-width: 500px) {
  .item-column {
    display: 100vw;
    margin-bottom: 10px;
  }
}
  </style>
  