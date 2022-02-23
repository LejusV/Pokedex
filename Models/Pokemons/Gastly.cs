using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gastly Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 62, 'height': 13, 'id': 92, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'disable', 'mega-drain', 'thunderbolt', 'thunder', 'toxic', 'psychic', 'hypnosis', 'rage', 'night-shade', 'mimic', 'double-team', 'confuse-ray', 'haze', 'bide', 'self-destruct', 'lick', 'smog', 'dream-eater', 'psywave', 'explosion', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'sludge-bomb', 'zap-cannon', 'destiny-bond', 'perish-song', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'torment', 'will-o-wisp', 'facade', 'taunt', 'trick', 'knock-off', 'skill-swap', 'grudge', 'snatch', 'secret-power', 'astonish', 'natural-gift', 'payback', 'embargo', 'sucker-punch', 'dark-pulse', 'energy-ball', 'trick-room', 'captivate', 'ominous-wind', 'wonder-room', 'venoshock', 'telekinesis', 'foul-play', 'round', 'clear-smog', 'hex', 'reflect-type', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'gastly', 'stats': {'hp': 30, 'attack': 35, 'defense': 30, 'special-attack': 100, 'special-defense': 35, 'speed': 80}, 'types': ['ghost', 'poison'], 'weight': 1, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'purple', 'shape': 'ball', 'habitat': 'cave', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ゴース', 'roomaji': 'Ghos', 'ko': '고오스', 'zh-Hant': '鬼斯', 'fr': 'Fantominus', 'de': 'Nebulak', 'es': 'Gastly', 'it': 'Gastly', 'en': 'Gastly', 'ja': 'ゴース', 'zh-Hans': '鬼斯'}, 'genera': {'ja-Hrkt': 'ガスじょうポケモン', 'ko': '가스포켓몬', 'zh-Hant': '氣體狀寶可夢', 'fr': 'Pokémon Gaz', 'de': 'Gas', 'es': 'Pokémon Gas', 'it': 'Pokémon Gas', 'en': 'Gas Pokémon', 'ja': 'ガスじょうポケモン', 'zh-Hans': '气体状宝可梦'}}
	public class SpecieGastly : PokemonSpecie
	{
#nullable enable
		private static SpecieGastly? _instance = null;
#nullable restore
        public static SpecieGastly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGastly();
                }
                return _instance;
            }
        }

		public SpecieGastly() : base(
			"Gastly",
			30, // HPs
			35, 30, // Attack & Defense
			100, 35, // Special Attack & Defense
			80			
		) {}
	}


	//Gastly Pokemon Class
	public class Gastly : Pokemon
	{

		public Gastly(string nickname, int level) : base(
			92,
			SpecieGastly.Instance, // Pokemon Specie
			nickname, level,
			Ghost.Instance, Poison.Instance			
		) {}

		public Gastly() : base(
			92,
			SpecieGastly.Instance, // Pokemon Specie
			Ghost.Instance, Poison.Instance			
		) {}
	}
}