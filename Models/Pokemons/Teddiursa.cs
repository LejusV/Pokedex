using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Teddiursa Specie to store common natural stats of every {'abilities': ['pickup', 'quick-feet', 'honey-gather'], 'base_experience': 66, 'height': 6, 'id': 216, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'thrash', 'double-edge', 'leer', 'roar', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'metronome', 'lick', 'swift', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'feint-attack', 'belly-drum', 'mud-slap', 'zap-cannon', 'endure', 'charm', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'sweet-scent', 'metal-claw', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'torment', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'yawn', 'secret-power', 'hyper-voice', 'fake-tears', 'rock-tomb', 'aerial-ace', 'bulk-up', 'covet', 'natural-gift', 'close-combat', 'payback', 'fling', 'last-resort', 'night-slash', 'seed-bomb', 'shadow-claw', 'gunk-shot', 'captivate', 'hone-claws', 'round', 'chip-away', 'retaliate', 'bulldoze', 'work-up', 'play-rough', 'play-nice', 'confide', 'baby-doll-eyes', 'power-up-punch'], 'name': 'teddiursa', 'stats': {'hp': 60, 'attack': 80, 'defense': 50, 'special-attack': 50, 'special-defense': 50, 'speed': 40}, 'types': ['normal'], 'weight': 88, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'brown', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヒメグマ', 'roomaji': 'Himeguma', 'ko': '깜지곰', 'zh-Hant': '熊寶寶', 'fr': 'Teddiursa', 'de': 'Teddiursa', 'es': 'Teddiursa', 'it': 'Teddiursa', 'en': 'Teddiursa', 'ja': 'ヒメグマ', 'zh-Hans': '熊宝宝'}, 'genera': {'ja-Hrkt': 'こぐまポケモン', 'ko': '아기곰포켓몬', 'zh-Hant': '小熊寶可夢', 'fr': 'Pokémon Mini Ours', 'de': 'Kleinbär', 'es': 'Pokémon Osito', 'it': 'Pokémon Orsetto', 'en': 'Little Bear Pokémon', 'ja': 'こぐまポケモン', 'zh-Hans': '小熊宝可梦'}}
	public class SpecieTeddiursa : PokemonSpecie
	{
#nullable enable
		private static SpecieTeddiursa? _instance = null;
#nullable restore
        public static SpecieTeddiursa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTeddiursa();
                }
                return _instance;
            }
        }

		public SpecieTeddiursa() : base(
			"Teddiursa",
			60, // HPs
			80, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			40			
		) {}
	}


	//Teddiursa Pokemon Class
	public class Teddiursa : Pokemon
	{

		public Teddiursa(string nickname, int level)
		: base(
				216,
				SpecieTeddiursa.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Teddiursa() : base(
			216,
			SpecieTeddiursa.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}