using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Purugly Specie to store common natural stats of every {'abilities': ['thick-fat', 'own-tempo', 'defiant'], 'base_experience': 158, 'height': 10, 'id': 432, 'moves': ['scratch', 'cut', 'headbutt', 'body-slam', 'growl', 'roar', 'hyper-beam', 'thunderbolt', 'thunder', 'dig', 'toxic', 'hypnosis', 'double-team', 'swift', 'dream-eater', 'flash', 'fury-swipes', 'rest', 'super-fang', 'slash', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'mud-slap', 'endure', 'charm', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'fake-out', 'torment', 'facade', 'taunt', 'assist', 'knock-off', 'snatch', 'secret-power', 'hyper-voice', 'aerial-ace', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'u-turn', 'payback', 'last-resort', 'sucker-punch', 'giga-impact', 'shadow-claw', 'captivate', 'hone-claws', 'foul-play', 'round', 'echoed-voice', 'retaliate', 'bulldoze', 'work-up', 'confide'], 'name': 'purugly', 'stats': {'hp': 71, 'attack': 82, 'defense': 64, 'special-attack': 64, 'special-defense': 59, 'speed': 112}, 'types': ['normal'], 'weight': 438, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 75, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ブニャット', 'roomaji': 'Bunyat', 'ko': '몬냥이', 'zh-Hant': '東施喵', 'fr': 'Chaffreux', 'de': 'Shnurgarst', 'es': 'Purugly', 'it': 'Purugly', 'en': 'Purugly', 'ja': 'ブニャット', 'zh-Hans': '东施喵'}, 'genera': {'ja-Hrkt': 'とらねこポケモン', 'ko': '얼룩고양이포켓몬', 'zh-Hant': '虎斑貓寶可夢', 'fr': 'Pokémon Chatigre', 'de': 'Tigerkatze', 'es': 'Pokémon Tigre Gato', 'it': 'Pokémon Gattotigre', 'en': 'Tiger Cat Pokémon', 'ja': 'とらねこポケモン', 'zh-Hans': '虎斑猫宝可梦'}}
	public class SpeciePurugly : PokemonSpecie
	{
#nullable enable
		private static SpeciePurugly? _instance = null;
#nullable restore
        public static SpeciePurugly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePurugly();
                }
                return _instance;
            }
        }

		public SpeciePurugly() : base(
			"Purugly",
			71, // HPs
			82, 64, // Attack & Defense
			64, 59, // Special Attack & Defense
			112			
		) {}
	}


	//Purugly Pokemon Class
	public class Purugly : Pokemon
	{

		public Purugly(string nickname, int level)
		: base(
				432,
				SpeciePurugly.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Purugly(int level)
		: base(
				432,
				SpeciePurugly.Instance, // Pokemon Specie
				"Purugly", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Purugly() : base(
			432,
			SpeciePurugly.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}