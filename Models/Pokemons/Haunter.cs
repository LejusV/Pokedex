using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Haunter Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 142, 'height': 16, 'id': 93, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'mega-drain', 'thunderbolt', 'thunder', 'toxic', 'psychic', 'hypnosis', 'rage', 'night-shade', 'mimic', 'double-team', 'confuse-ray', 'bide', 'self-destruct', 'lick', 'dream-eater', 'psywave', 'explosion', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'sludge-bomb', 'zap-cannon', 'destiny-bond', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'torment', 'will-o-wisp', 'facade', 'taunt', 'trick', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'shadow-punch', 'natural-gift', 'payback', 'embargo', 'fling', 'sucker-punch', 'poison-jab', 'dark-pulse', 'energy-ball', 'shadow-claw', 'trick-room', 'captivate', 'ominous-wind', 'wonder-room', 'venoshock', 'telekinesis', 'foul-play', 'round', 'hex', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'haunter', 'stats': {'hp': 45, 'attack': 50, 'defense': 45, 'special-attack': 115, 'special-defense': 55, 'speed': 95}, 'types': ['ghost', 'poison'], 'weight': 1, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'purple', 'shape': 'arms', 'habitat': 'cave', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ゴースト', 'roomaji': 'Ghost', 'ko': '고우스트', 'zh-Hant': '鬼斯通', 'fr': 'Spectrum', 'de': 'Alpollo', 'es': 'Haunter', 'it': 'Haunter', 'en': 'Haunter', 'ja': 'ゴースト', 'zh-Hans': '鬼斯通'}, 'genera': {'ja-Hrkt': 'ガスじょうポケモン', 'ko': '가스포켓몬', 'zh-Hant': '氣體狀寶可夢', 'fr': 'Pokémon Gaz', 'de': 'Gas', 'es': 'Pokémon Gas', 'it': 'Pokémon Gas', 'en': 'Gas Pokémon', 'ja': 'ガスじょうポケモン', 'zh-Hans': '气体状宝可梦'}}
	public class SpecieHaunter : PokemonSpecie
	{
#nullable enable
		private static SpecieHaunter? _instance = null;
#nullable restore
        public static SpecieHaunter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHaunter();
                }
                return _instance;
            }
        }

		public SpecieHaunter() : base(
			"Haunter",
			45, // HPs
			50, 45, // Attack & Defense
			115, 55, // Special Attack & Defense
			95			
		) {}
	}


	//Haunter Pokemon Class
	public class Haunter : Pokemon
	{

		public Haunter(string nickname, int level)
		: base(
				93,
				SpecieHaunter.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Haunter() : base(
			93,
			SpecieHaunter.Instance, // Pokemon Specie
			Ghost.Instance, Poison.Instance			
		) {}
	}
}