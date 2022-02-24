using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mightyena Specie to store common natural stats of every {'abilities': ['intimidate', 'quick-feet', 'moxie'], 'base_experience': 147, 'height': 10, 'id': 262, 'moves': ['sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'bite', 'roar', 'hyper-beam', 'counter', 'strength', 'dig', 'toxic', 'mimic', 'double-team', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'mud-slap', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'shadow-ball', 'rock-smash', 'uproar', 'torment', 'facade', 'taunt', 'yawn', 'snatch', 'secret-power', 'hyper-voice', 'odor-sleuth', 'howl', 'covet', 'natural-gift', 'payback', 'assurance', 'embargo', 'sucker-punch', 'dark-pulse', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'captivate', 'foul-play', 'round', 'incinerate', 'retaliate', 'snarl', 'play-rough', 'confide'], 'name': 'mightyena', 'stats': {'hp': 70, 'attack': 90, 'defense': 70, 'special-attack': 60, 'special-defense': 60, 'speed': 70}, 'types': ['dark'], 'weight': 370, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 127, 'color': 'gray', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'グラエナ', 'roomaji': 'Guraena', 'ko': '그라에나', 'zh-Hant': '大狼犬', 'fr': 'Grahyèna', 'de': 'Magnayen', 'es': 'Mightyena', 'it': 'Mightyena', 'en': 'Mightyena', 'ja': 'グラエナ', 'zh-Hans': '大狼犬'}, 'genera': {'ja-Hrkt': 'かみつきポケモン', 'ko': '물어뜯기포켓몬', 'zh-Hant': '緊咬寶可夢', 'fr': 'Pokémon Morsure', 'de': 'Biss', 'es': 'Pokémon Mordisco', 'it': 'Pokémon Morso', 'en': 'Bite Pokémon', 'ja': 'かみつきポケモン', 'zh-Hans': '紧咬宝可梦'}}
	public class SpecieMightyena : PokemonSpecie
	{
#nullable enable
		private static SpecieMightyena? _instance = null;
#nullable restore
        public static SpecieMightyena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMightyena();
                }
                return _instance;
            }
        }

		public SpecieMightyena() : base(
			"Mightyena",
			70, // HPs
			90, 70, // Attack & Defense
			60, 60, // Special Attack & Defense
			70			
		) {}
	}


	//Mightyena Pokemon Class
	public class Mightyena : Pokemon
	{

		public Mightyena(string nickname, int level)
		: base(
				262,
				SpecieMightyena.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mightyena() : base(
			262,
			SpecieMightyena.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}