using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gible Specie to store common natural stats of every {'abilities': ['sand-veil', 'rough-skin'], 'base_experience': 60, 'height': 7, 'id': 443, 'moves': ['cut', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'thrash', 'double-edge', 'roar', 'flamethrower', 'strength', 'dragon-rage', 'earthquake', 'dig', 'toxic', 'double-team', 'fire-blast', 'swift', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'metal-claw', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'secret-power', 'rock-tomb', 'sand-tomb', 'aerial-ace', 'dragon-claw', 'mud-shot', 'natural-gift', 'dragon-pulse', 'dragon-rush', 'earth-power', 'shadow-claw', 'rock-climb', 'draco-meteor', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'round', 'incinerate', 'bulldoze', 'confide'], 'name': 'gible', 'stats': {'hp': 58, 'attack': 70, 'defense': 45, 'special-attack': 40, 'special-defense': 45, 'speed': 42}, 'types': ['dragon', 'ground'], 'weight': 205, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'フカマル', 'roomaji': 'Fukamaru', 'ko': '딥상어동', 'zh-Hant': '圓陸鯊', 'fr': 'Griknot', 'de': 'Kaumalat', 'es': 'Gible', 'it': 'Gible', 'en': 'Gible', 'ja': 'フカマル', 'zh-Hans': '圆陆鲨'}, 'genera': {'ja-Hrkt': 'りくザメポケモン', 'ko': '육지상어포켓몬', 'zh-Hant': '陸鯊寶可夢', 'fr': 'Pokémon Terrequin', 'de': 'Landhai', 'es': 'Pokémon Terrascualo', 'it': 'Pokémon Squaloterra', 'en': 'Land Shark Pokémon', 'ja': 'りくザメポケモン', 'zh-Hans': '陆鲨宝可梦'}}
	public class SpecieGible : PokemonSpecie
	{
#nullable enable
		private static SpecieGible? _instance = null;
#nullable restore
        public static SpecieGible Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGible();
                }
                return _instance;
            }
        }

		public SpecieGible() : base(
			"Gible",
			58, // HPs
			70, 45, // Attack & Defense
			40, 45, // Special Attack & Defense
			42			
		) {}
	}


	//Gible Pokemon Class
	public class Gible : Pokemon
	{

		public Gible(string nickname, int level)
		: base(
				443,
				SpecieGible.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gible() : base(
			443,
			SpecieGible.Instance, // Pokemon Specie
			Dragon.Instance, Ground.Instance			
		) {}
	}
}