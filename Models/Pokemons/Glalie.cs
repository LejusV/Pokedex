using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Glalie Specie to store common natural stats of every {'abilities': ['inner-focus', 'ice-body', 'moody'], 'base_experience': 168, 'height': 15, 'id': 362, 'moves': ['headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'ice-beam', 'blizzard', 'hyper-beam', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'self-destruct', 'flash', 'explosion', 'rest', 'super-fang', 'substitute', 'snore', 'spite', 'powder-snow', 'protect', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'crunch', 'shadow-ball', 'hail', 'torment', 'facade', 'taunt', 'secret-power', 'signal-beam', 'sheer-cold', 'block', 'water-pulse', 'gyro-ball', 'natural-gift', 'payback', 'dark-pulse', 'giga-impact', 'avalanche', 'ice-shard', 'ice-fang', 'iron-head', 'captivate', 'round', 'bulldoze', 'frost-breath', 'freeze-dry', 'confide'], 'name': 'glalie', 'stats': {'hp': 80, 'attack': 80, 'defense': 80, 'special-attack': 80, 'special-defense': 80, 'speed': 80}, 'types': ['ice'], 'weight': 2565, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'gray', 'shape': 'ball', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['fairy', 'mineral'], 'names': {'ja-Hrkt': 'オニゴーリ', 'roomaji': 'Onigohri', 'ko': '얼음귀신', 'zh-Hant': '冰鬼護', 'fr': 'Oniglali', 'de': 'Firnontor', 'es': 'Glalie', 'it': 'Glalie', 'en': 'Glalie', 'ja': 'オニゴーリ', 'zh-Hans': '冰鬼护'}, 'genera': {'ja-Hrkt': 'がんめんポケモン', 'ko': '얼굴포켓몬', 'zh-Hant': '臉面寶可夢', 'fr': 'Pokémon Face', 'de': 'Antlitz', 'es': 'Pokémon Cara', 'it': 'Pokémon Tuttomuso', 'en': 'Face Pokémon', 'ja': 'がんめんポケモン', 'zh-Hans': '脸面宝可梦'}}
	public class SpecieGlalie : PokemonSpecie
	{
#nullable enable
		private static SpecieGlalie? _instance = null;
#nullable restore
        public static SpecieGlalie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGlalie();
                }
                return _instance;
            }
        }

		public SpecieGlalie() : base(
			"Glalie",
			80, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			80			
		) {}
	}


	//Glalie Pokemon Class
	public class Glalie : Pokemon
	{

		public Glalie(string nickname, int level)
		: base(
				362,
				SpecieGlalie.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Glalie(int level)
		: base(
				362,
				SpecieGlalie.Instance, // Pokemon Specie
				"Glalie", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Glalie() : base(
			362,
			SpecieGlalie.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}