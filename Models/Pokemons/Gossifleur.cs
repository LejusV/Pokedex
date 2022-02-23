using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gossifleur Specie to store common natural stats of every {'abilities': ['cotton-down', 'regenerator', 'effect-spore'], 'base_experience': 50, 'height': 4, 'id': 829, 'moves': [], 'name': 'gossifleur', 'stats': {'hp': 40, 'attack': 40, 'defense': 60, 'special-attack': 40, 'special-defense': 60, 'speed': 10}, 'types': ['grass'], 'weight': 22, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'green', 'shape': 'blob', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ヒメンカ', 'ko': '꼬모카', 'zh-Hant': '幼棉棉', 'fr': 'Tournicoton', 'de': 'Cottini', 'es': 'Gossifleur', 'it': 'Gossifleur', 'en': 'Gossifleur', 'ja': 'ヒメンカ', 'zh-Hans': '幼棉棉'}, 'genera': {'ja-Hrkt': 'はなかざりポケモン', 'ko': '꽃장식포켓몬', 'zh-Hant': '花飾寶可夢', 'fr': 'Pokémon Chef-Fleur', 'de': 'Blumenzier', 'es': 'Pokémon Adornofloral', 'it': 'Pokémon Fiorfronzolo', 'en': 'Flowering Pokémon', 'ja': 'はなかざりポケモン', 'zh-Hans': '花饰宝可梦'}}
	public class SpecieGossifleur : PokemonSpecie
	{
#nullable enable
		private static SpecieGossifleur? _instance = null;
#nullable restore
        public static SpecieGossifleur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGossifleur();
                }
                return _instance;
            }
        }

		public SpecieGossifleur() : base(
			"Gossifleur",
			40, // HPs
			40, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			10			
		) {}
	}


	//Gossifleur Pokemon Class
	public class Gossifleur : Pokemon
	{

		public Gossifleur(string nickname, int level) : base(
			829,
			SpecieGossifleur.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Gossifleur() : base(
			829,
			SpecieGossifleur.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}