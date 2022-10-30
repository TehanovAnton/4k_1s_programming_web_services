import { defineStore } from "pinia"
import { ref } from "vue";

export const useFiltersStore = defineStore('filters', () => {
    const state = ref({ limit: '', sort: '', minId: '', maxId: '' });

    return { state }
})