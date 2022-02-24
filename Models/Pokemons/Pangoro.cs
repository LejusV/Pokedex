using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pangoro Specie to store common natural stats of every {'abilities': ['iron-fist', 'mold-breaker', 'scrappy'], 'base_experience': 173, 'height': 21, 'id': 675, 'moves': ['karate-chop', 'comet-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'tackle', 'body-slam', 'leer', 'roar', 'surf', 'hyper-beam', 'low-kick', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'spite', 'protect', 'sludge-bomb', 'outrage', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'vital-throw', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'knock-off', 'endeavor', 'snatch', 'secret-power', 'arm-thrust', 'hyper-voice', 'rock-tomb', 'sky-uppercut', 'aerial-ace', 'block', 'dragon-claw', 'bulk-up', 'covet', 'hammer-arm', 'payback', 'embargo', 'fling', 'poison-jab', 'dark-pulse', 'x-scissor', 'drain-punch', 'focus-blast', 'giga-impact', 'bullet-punch', 'shadow-claw', 'zen-headbutt', 'gunk-shot', 'iron-head', 'stone-edge', 'grass-knot', 'hone-claws', 'low-sweep', 'foul-play', 'entrainment', 'round', 'echoed-voice', 'circle-throw', 'quash', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'snarl', 'parting-shot', 'confide', 'infestation', 'power-up-punch'], 'name': 'pangoro', 'stats': {'hp': 95, 'attack': 124, 'defense': 78, 'special-attack': 69, 'special-defense': 71, 'speed': 58}, 'types': ['fighting', 'dark'], 'weight': 1360, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 65, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'ゴロンダ', 'ko': '부란다', 'zh-Hant': '流氓熊貓', 'fr': 'Pandarbare', 'de': 'Pandagro', 'es': 'Pangoro', 'it': 'Pangoro', 'en': 'Pangoro', 'ja': 'ゴロンダ', 'zh-Hans': '流氓熊猫'}, 'genera': {'ja-Hrkt': 'こわもてポケモン', 'ko': '무서운얼굴포켓몬', 'zh-Hant': '惡顏寶可夢', 'fr': 'Pokémon Patibulaire', 'de': 'Gaunerblick', 'es': 'Pokémon Rostro Fiero', 'it': 'Pokémon Occhiotruce', 'en': 'Daunting Pokémon', 'ja': 'こわもてポケモン', 'zh-Hans': '恶颜宝可梦'}}
	public class SpeciePangoro : PokemonSpecie
	{
#nullable enable
		private static SpeciePangoro? _instance = null;
#nullable restore
        public static SpeciePangoro Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePangoro();
                }
                return _instance;
            }
        }

		public SpeciePangoro() : base(
			"Pangoro",
			95, // HPs
			124, 78, // Attack & Defense
			69, 71, // Special Attack & Defense
			58			
		) {}
	}


	//Pangoro Pokemon Class
	public class Pangoro : Pokemon
	{

		public Pangoro(string nickname, int level)
		: base(
				675,
				SpeciePangoro.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pangoro() : base(
			675,
			SpeciePangoro.Instance, // Pokemon Specie
			Fighting.Instance, Dark.Instance			
		) {}
	}
}