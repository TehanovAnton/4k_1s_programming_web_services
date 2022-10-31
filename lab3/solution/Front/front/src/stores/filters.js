import { defineStore } from "pinia"
import { ref } from "vue";

export const useFiltersStore = defineStore('filters', () => {
    const state = ref({ limit: '', sort: '', offset: '', minId: '', maxId: '' });

    return { state }
})