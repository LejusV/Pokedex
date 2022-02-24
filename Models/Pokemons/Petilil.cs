using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Petilil Specie to store common natural stats of every {'abilities': ['chlorophyll', 'own-tempo', 'leaf-guard'], 'base_experience': 56, 'height': 5, 'id': 548, 'moves': ['cut', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'stun-spore', 'sleep-powder', 'toxic', 'double-team', 'bide', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'encore', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'helping-hand', 'ingrain', 'secret-power', 'aromatherapy', 'grass-whistle', 'covet', 'magical-leaf', 'healing-wish', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'leaf-storm', 'grass-knot', 'entrainment', 'after-you', 'round', 'confide'], 'name': 'petilil', 'stats': {'hp': 45, 'attack': 35, 'defense': 50, 'special-attack': 70, 'special-defense': 50, 'speed': 30}, 'types': ['grass'], 'weight': 66, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 190, 'color': 'green', 'shape': 'blob', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'チュリネ', 'ko': '치릴리', 'zh-Hant': '百合根娃娃', 'fr': 'Chlorobule', 'de': 'Lilminip', 'es': 'Petilil', 'it': 'Petilil', 'en': 'Petilil', 'ja': 'チュリネ', 'zh-Hans': '百合根娃娃'}, 'genera': {'ja-Hrkt': 'ねっこポケモン', 'ko': '뿌리포켓몬', 'zh-Hant': '根莖寶可夢', 'fr': 'Pokémon Racine', 'de': 'Wurzel', 'es': 'Pokémon Bulbo', 'it': 'Pokémon Radice', 'en': 'Bulb Pokémon', 'ja': 'ねっこポケモン', 'zh-Hans': '根茎宝可梦'}}
	public class SpeciePetilil : PokemonSpecie
	{
#nullable enable
		private static SpeciePetilil? _instance = null;
#nullable restore
        public static SpeciePetilil Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePetilil();
                }
                return _instance;
            }
        }

		public SpeciePetilil() : base(
			"Petilil",
			45, // HPs
			35, 50, // Attack & Defense
			70, 50, // Special Attack & Defense
			30			
		) {}
	}


	//Petilil Pokemon Class
	public class Petilil : Pokemon
	{

		public Petilil(string nickname, int level)
		: base(
				548,
				SpeciePetilil.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Petilil() : base(
			548,
			SpeciePetilil.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}