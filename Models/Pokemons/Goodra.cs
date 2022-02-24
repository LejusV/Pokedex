using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Goodra Specie to store common natural stats of every {'abilities': ['sap-sipper', 'hydration', 'gooey'], 'base_experience': 270, 'height': 20, 'id': 706, 'moves': ['fire-punch', 'thunder-punch', 'tackle', 'body-slam', 'flamethrower', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'absorb', 'thunderbolt', 'thunder', 'earthquake', 'toxic', 'double-team', 'bide', 'fire-blast', 'bubble', 'rest', 'rock-slide', 'substitute', 'snore', 'flail', 'protect', 'sludge-bomb', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'hail', 'facade', 'focus-punch', 'superpower', 'secret-power', 'muddy-water', 'shock-wave', 'water-pulse', 'feint', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'giga-impact', 'draco-meteor', 'power-whip', 'sludge-wave', 'round', 'incinerate', 'bulldoze', 'dragon-tail', 'confide', 'infestation', 'brutal-swing'], 'name': 'goodra', 'stats': {'hp': 90, 'attack': 100, 'defense': 70, 'special-attack': 110, 'special-defense': 150, 'speed': 80}, 'types': ['dragon'], 'weight': 1505, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'ヌメルゴン', 'ko': '미끄래곤', 'zh-Hant': '黏美龍', 'fr': 'Muplodocus', 'de': 'Viscogon', 'es': 'Goodra', 'it': 'Goodra', 'en': 'Goodra', 'ja': 'ヌメルゴン', 'zh-Hans': '黏美龙'}, 'genera': {'ja-Hrkt': 'ドラゴンポケモン', 'ko': '드래곤포켓몬', 'zh-Hant': '龍寶可夢', 'fr': 'Pokémon Dragon', 'de': 'Drache', 'es': 'Pokémon Dragón', 'it': 'Pokémon Drago', 'en': 'Dragon Pokémon', 'ja': 'ドラゴンポケモン', 'zh-Hans': '龙宝可梦'}}
	public class SpecieGoodra : PokemonSpecie
	{
#nullable enable
		private static SpecieGoodra? _instance = null;
#nullable restore
        public static SpecieGoodra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGoodra();
                }
                return _instance;
            }
        }

		public SpecieGoodra() : base(
			"Goodra",
			90, // HPs
			100, 70, // Attack & Defense
			110, 150, // Special Attack & Defense
			80			
		) {}
	}


	//Goodra Pokemon Class
	public class Goodra : Pokemon
	{

		public Goodra(string nickname, int level)
		: base(
				706,
				SpecieGoodra.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Goodra(int level)
		: base(
				706,
				SpecieGoodra.Instance, // Pokemon Specie
				"Goodra", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Goodra() : base(
			706,
			SpecieGoodra.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}