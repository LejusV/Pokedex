using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Manectric Specie to store common natural stats of every {'abilities': ['static', 'lightning-rod', 'minus'], 'base_experience': 166, 'height': 15, 'id': 310, 'moves': ['headbutt', 'tackle', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'flamethrower', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'quick-attack', 'mimic', 'double-team', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'endure', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'uproar', 'facade', 'charge', 'secret-power', 'overheat', 'odor-sleuth', 'signal-beam', 'howl', 'shock-wave', 'natural-gift', 'magnet-rise', 'giga-impact', 'thunder-fang', 'fire-fang', 'discharge', 'captivate', 'charge-beam', 'round', 'volt-switch', 'wild-charge', 'snarl', 'confide', 'electric-terrain'], 'name': 'manectric', 'stats': {'hp': 70, 'attack': 75, 'defense': 60, 'special-attack': 105, 'special-defense': 60, 'speed': 105}, 'types': ['electric'], 'weight': 402, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ライボルト', 'roomaji': 'Livolt', 'ko': '썬더볼트', 'zh-Hant': '雷電獸', 'fr': 'Élecsprint', 'de': 'Voltenso', 'es': 'Manectric', 'it': 'Manectric', 'en': 'Manectric', 'ja': 'ライボルト', 'zh-Hans': '雷电兽'}, 'genera': {'ja-Hrkt': 'ほうでんポケモン', 'ko': '방전포켓몬', 'zh-Hant': '放電寶可夢', 'fr': 'Pokémon Décharge', 'de': 'Entladung', 'es': 'Pokémon Descarga', 'it': 'Pokémon Scossa', 'en': 'Discharge Pokémon', 'ja': 'ほうでんポケモン', 'zh-Hans': '放电宝可梦'}}
	public class SpecieManectric : PokemonSpecie
	{
#nullable enable
		private static SpecieManectric? _instance = null;
#nullable restore
        public static SpecieManectric Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieManectric();
                }
                return _instance;
            }
        }

		public SpecieManectric() : base(
			"Manectric",
			70, // HPs
			75, 60, // Attack & Defense
			105, 60, // Special Attack & Defense
			105			
		) {}
	}


	//Manectric Pokemon Class
	public class Manectric : Pokemon
	{

		public Manectric(string nickname, int level) : base(
			310,
			SpecieManectric.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Manectric() : base(
			310,
			SpecieManectric.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}