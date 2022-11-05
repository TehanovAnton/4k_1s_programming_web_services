import { defineStore } from "pinia"
import { computed, ref, watch } from "vue";

export const useFiltersStore = defineStore('filters', () => {
  const columns = ref({ id: true, name: true, phone: true })  

  const columnAttribute = (presence, value) => {
    return presence ? value : ''
  }
  
  const state = ref({ 
    limit: '', 
    sort: '', 
    offset: '', 
    minId: '', 
    maxId: '', 
    like: '', 
    globallike: '',
    columns: computed(() => {
      return `${columnAttribute(columns.value.id, 'Id')},` +
             `${columnAttribute(columns.value.name, 'Name')},` +
             `${columnAttribute(columns.value.phone, 'Phone')}`
    })
  });

  return { state, columns }
})