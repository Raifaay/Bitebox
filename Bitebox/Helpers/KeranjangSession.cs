using System.Collections.Generic;
using Bitebox.Models.Entity;

namespace Bitebox.Helpers
{
    public static class KeranjangSession
    {
        public static List<KeranjangItem> Items { get; set; } = new List<KeranjangItem>();

        public static void TambahItem(KeranjangItem item)
        {
            var existing = Items.Find(x => x.IdMenu == item.IdMenu);
            if (existing != null)
                existing.Jumlah++;
            else
                Items.Add(item);
        }

        public static void HapusItem(int idMenu)
        {
            Items.RemoveAll(x => x.IdMenu == idMenu);
        }

        public static void Clear()
        {
            Items.Clear();
        }

        public static int TotalHarga()
        {
            int total = 0;
            foreach (var item in Items)
                total += item.Subtotal;
            return total;
        }
    }
}