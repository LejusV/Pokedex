using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Braviary Specie to store common natural stats of every {'abilities': ['keen-eye', 'sheer-force', 'defiant'], 'base_experience': 179, 'height': 15, 'id': 628, 'moves': ['cut', 'wing-attack', 'whirlwind', 'fly', 'fury-attack', 'thrash', 'leer', 'hyper-beam', 'peck', 'strength', 'toxic', 'double-team', 'sky-attack', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'heat-wave', 'facade', 'superpower', 'secret-power', 'crush-claw', 'rock-tomb', 'aerial-ace', 'bulk-up', 'roost', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'brave-bird', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'defog', 'hone-claws', 'round', 'sky-drop', 'retaliate', 'work-up', 'confide'], 'name': 'braviary', 'stats': {'hp': 100, 'attack': 123, 'defense': 75, 'special-attack': 57, 'special-defense': 75, 'speed': 80}, 'types': ['normal', 'flying'], 'weight': 410, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 60, 'color': 'red', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ウォーグル', 'ko': '워글', 'zh-Hant': '勇士雄鷹', 'fr': 'Gueriaigle', 'de': 'Washakwil', 'es': 'Braviary', 'it': 'Braviary', 'en': 'Braviary', 'ja': 'ウォーグル', 'zh-Hans': '勇士雄鹰'}, 'genera': {'ja-Hrkt': 'ゆうもうポケモン', 'ko': '용맹포켓몬', 'zh-Hant': '勇猛寶可夢', 'fr': 'Pokémon Vaillant', 'de': 'Kühnheit', 'es': 'Pokémon Aguerrido', 'it': 'Pokémon Baldanza', 'en': 'Valiant Pokémon', 'ja': 'ゆうもうポケモン', 'zh-Hans': '勇猛宝可梦'}}
	public class SpecieBraviary : PokemonSpecie
	{
#nullable enable
		private static SpecieBraviary? _instance = null;
#nullable restore
        public static SpecieBraviary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBraviary();
                }
                return _instance;
            }
        }

		public SpecieBraviary() : base(
			"Braviary",
			100, // HPs
			123, 75, // Attack & Defense
			57, 75, // Special Attack & Defense
			80			
		) {}
	}


	//Braviary Pokemon Class
	public class Braviary : Pokemon
	{

		public Braviary(string nickname, int level)
		: base(
				628,
				SpecieBraviary.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Braviary() : base(
			628,
			SpecieBraviary.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}