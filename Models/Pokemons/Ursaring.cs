using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ursaring Specie to store common natural stats of every {'abilities': ['guts', 'quick-feet', 'unnerve'], 'base_experience': 175, 'height': 18, 'id': 217, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'thrash', 'double-edge', 'leer', 'roar', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'metronome', 'lick', 'swift', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'feint-attack', 'mud-slap', 'zap-cannon', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'sweet-scent', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'secret-power', 'hyper-voice', 'fake-tears', 'rock-tomb', 'aerial-ace', 'bulk-up', 'covet', 'hammer-arm', 'natural-gift', 'payback', 'fling', 'last-resort', 'seed-bomb', 'focus-blast', 'giga-impact', 'avalanche', 'shadow-claw', 'rock-climb', 'gunk-shot', 'stone-edge', 'captivate', 'hone-claws', 'smack-down', 'round', 'retaliate', 'bulldoze', 'work-up', 'play-nice', 'confide', 'power-up-punch'], 'name': 'ursaring', 'stats': {'hp': 90, 'attack': 130, 'defense': 75, 'special-attack': 75, 'special-defense': 75, 'speed': 55}, 'types': ['normal'], 'weight': 1258, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'brown', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'リングマ', 'roomaji': 'Ringuma', 'ko': '링곰', 'zh-Hant': '圈圈熊', 'fr': 'Ursaring', 'de': 'Ursaring', 'es': 'Ursaring', 'it': 'Ursaring', 'en': 'Ursaring', 'ja': 'リングマ', 'zh-Hans': '圈圈熊'}, 'genera': {'ja-Hrkt': 'とうみんポケモン', 'ko': '동면포켓몬', 'zh-Hant': '冬眠寶可夢', 'fr': 'Pokémon Hibernant', 'de': 'Schläfer', 'es': 'Pokémon Hibernante', 'it': 'Pokémon Letargo', 'en': 'Hibernator Pokémon', 'ja': 'とうみんポケモン', 'zh-Hans': '冬眠宝可梦'}}
	public class SpecieUrsaring : PokemonSpecie
	{
#nullable enable
		private static SpecieUrsaring? _instance = null;
#nullable restore
        public static SpecieUrsaring Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUrsaring();
                }
                return _instance;
            }
        }

		public SpecieUrsaring() : base(
			"Ursaring",
			90, // HPs
			130, 75, // Attack & Defense
			75, 75, // Special Attack & Defense
			55			
		) {}
	}


	//Ursaring Pokemon Class
	public class Ursaring : Pokemon
	{

		public Ursaring(string nickname, int level)
		: base(
				217,
				SpecieUrsaring.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ursaring(int level)
		: base(
				217,
				SpecieUrsaring.Instance, // Pokemon Specie
				"Ursaring", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ursaring() : base(
			217,
			SpecieUrsaring.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}