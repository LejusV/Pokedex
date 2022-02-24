using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bonsly Specie to store common natural stats of every {'abilities': ['sturdy', 'rock-head', 'rattled'], 'base_experience': 58, 'height': 5, 'id': 438, 'moves': ['slam', 'headbutt', 'double-edge', 'low-kick', 'counter', 'rock-throw', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'defense-curl', 'self-destruct', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'feint-attack', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'psych-up', 'uproar', 'facade', 'nature-power', 'helping-hand', 'role-play', 'brick-break', 'secret-power', 'fake-tears', 'rock-tomb', 'sand-tomb', 'block', 'covet', 'calm-mind', 'natural-gift', 'copycat', 'sucker-punch', 'rock-polish', 'earth-power', 'captivate', 'stealth-rock', 'smack-down', 'foul-play', 'after-you', 'round', 'confide', 'tearful-look'], 'name': 'bonsly', 'stats': {'hp': 50, 'attack': 80, 'defense': 95, 'special-attack': 10, 'special-defense': 45, 'speed': 10}, 'types': ['rock'], 'weight': 150, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'legs', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ウソハチ', 'roomaji': 'Usohachi', 'ko': '꼬지지', 'zh-Hant': '盆才怪', 'fr': 'Manzaï', 'de': 'Mobai', 'es': 'Bonsly', 'it': 'Bonsly', 'en': 'Bonsly', 'ja': 'ウソハチ', 'zh-Hans': '盆才怪'}, 'genera': {'ja-Hrkt': 'ぼんさいポケモン', 'ko': '분재포켓몬', 'zh-Hant': '盆栽寶可夢', 'fr': 'Pokémon Bonsaï', 'de': 'Bonsai', 'es': 'Pokémon Bonsái', 'it': 'Pokémon Bonsai', 'en': 'Bonsai Pokémon', 'ja': 'ぼんさいポケモン', 'zh-Hans': '盆栽宝可梦'}}
	public class SpecieBonsly : PokemonSpecie
	{
#nullable enable
		private static SpecieBonsly? _instance = null;
#nullable restore
        public static SpecieBonsly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBonsly();
                }
                return _instance;
            }
        }

		public SpecieBonsly() : base(
			"Bonsly",
			50, // HPs
			80, 95, // Attack & Defense
			10, 45, // Special Attack & Defense
			10			
		) {}
	}


	//Bonsly Pokemon Class
	public class Bonsly : Pokemon
	{

		public Bonsly(string nickname, int level)
		: base(
				438,
				SpecieBonsly.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bonsly() : base(
			438,
			SpecieBonsly.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}