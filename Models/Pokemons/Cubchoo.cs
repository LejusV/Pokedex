using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cubchoo Specie to store common natural stats of every {'abilities': ['snow-cloak', 'slush-rush', 'rattled'], 'base_experience': 61, 'height': 5, 'id': 613, 'moves': ['ice-punch', 'cut', 'thrash', 'growl', 'surf', 'ice-beam', 'blizzard', 'low-kick', 'strength', 'dig', 'toxic', 'double-team', 'bide', 'fury-swipes', 'rest', 'slash', 'substitute', 'snore', 'flail', 'powder-snow', 'protect', 'icy-wind', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'hidden-power', 'rain-dance', 'rock-smash', 'hail', 'facade', 'focus-punch', 'superpower', 'yawn', 'secret-power', 'rock-tomb', 'sheer-cold', 'aerial-ace', 'covet', 'water-pulse', 'brine', 'assurance', 'fling', 'night-slash', 'avalanche', 'shadow-claw', 'grass-knot', 'hone-claws', 'round', 'echoed-voice', 'frost-breath', 'play-rough', 'play-nice', 'confide', 'power-up-punch'], 'name': 'cubchoo', 'stats': {'hp': 55, 'attack': 70, 'defense': 40, 'special-attack': 60, 'special-defense': 40, 'speed': 40}, 'types': ['ice'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'white', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'クマシュン', 'ko': '코고미', 'zh-Hant': '噴嚏熊', 'fr': 'Polarhume', 'de': 'Petznief', 'es': 'Cubchoo', 'it': 'Cubchoo', 'en': 'Cubchoo', 'ja': 'クマシュン', 'zh-Hans': '喷嚏熊'}, 'genera': {'ja-Hrkt': 'ひょうけつポケモン', 'ko': '빙결포켓몬', 'zh-Hant': '結冰寶可夢', 'fr': 'Pokémon Gelé', 'de': 'Eisscholle', 'es': 'Pokémon Congelación', 'it': 'Pokémon Freddo', 'en': 'Chill Pokémon', 'ja': 'ひょうけつポケモン', 'zh-Hans': '结冰宝可梦'}}
	public class SpecieCubchoo : PokemonSpecie
	{
#nullable enable
		private static SpecieCubchoo? _instance = null;
#nullable restore
        public static SpecieCubchoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCubchoo();
                }
                return _instance;
            }
        }

		public SpecieCubchoo() : base(
			"Cubchoo",
			55, // HPs
			70, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			40			
		) {}
	}


	//Cubchoo Pokemon Class
	public class Cubchoo : Pokemon
	{

		public Cubchoo(string nickname, int level)
		: base(
				613,
				SpecieCubchoo.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cubchoo() : base(
			613,
			SpecieCubchoo.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}