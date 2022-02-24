using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Glameow Specie to store common natural stats of every {'abilities': ['limber', 'own-tempo', 'keen-eye'], 'base_experience': 62, 'height': 5, 'id': 431, 'moves': ['scratch', 'cut', 'sand-attack', 'headbutt', 'tail-whip', 'bite', 'growl', 'thunderbolt', 'thunder', 'dig', 'toxic', 'hypnosis', 'quick-attack', 'double-team', 'swift', 'dream-eater', 'flash', 'fury-swipes', 'rest', 'super-fang', 'slash', 'substitute', 'thief', 'snore', 'flail', 'protect', 'feint-attack', 'mud-slap', 'endure', 'charm', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'fake-out', 'torment', 'facade', 'taunt', 'assist', 'knock-off', 'snatch', 'secret-power', 'hyper-voice', 'fake-tears', 'aerial-ace', 'covet', 'shock-wave', 'water-pulse', 'wake-up-slap', 'natural-gift', 'u-turn', 'payback', 'assurance', 'last-resort', 'sucker-punch', 'shadow-claw', 'captivate', 'hone-claws', 'foul-play', 'round', 'echoed-voice', 'retaliate', 'work-up', 'play-rough', 'confide'], 'name': 'glameow', 'stats': {'hp': 49, 'attack': 55, 'defense': 42, 'special-attack': 42, 'special-defense': 37, 'speed': 85}, 'types': ['normal'], 'weight': 39, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 190, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ニャルマー', 'roomaji': 'Nyarmar', 'ko': '나옹마', 'zh-Hant': '魅力喵', 'fr': 'Chaglam', 'de': 'Charmian', 'es': 'Glameow', 'it': 'Glameow', 'en': 'Glameow', 'ja': 'ニャルマー', 'zh-Hans': '魅力喵'}, 'genera': {'ja-Hrkt': 'ねこかぶりポケモン', 'ko': '내숭포켓몬', 'zh-Hant': '裝乖寶可夢', 'fr': 'Pokémon Chafouin', 'de': 'Fies', 'es': 'Pokémon Gastuto', 'it': 'Pokémon Felide', 'en': 'Catty Pokémon', 'ja': 'ねこかぶりポケモン', 'zh-Hans': '装乖宝可梦'}}
	public class SpecieGlameow : PokemonSpecie
	{
#nullable enable
		private static SpecieGlameow? _instance = null;
#nullable restore
        public static SpecieGlameow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGlameow();
                }
                return _instance;
            }
        }

		public SpecieGlameow() : base(
			"Glameow",
			49, // HPs
			55, 42, // Attack & Defense
			42, 37, // Special Attack & Defense
			85			
		) {}
	}


	//Glameow Pokemon Class
	public class Glameow : Pokemon
	{

		public Glameow(string nickname, int level)
		: base(
				431,
				SpecieGlameow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Glameow() : base(
			431,
			SpecieGlameow.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}