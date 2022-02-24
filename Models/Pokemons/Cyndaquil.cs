using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cyndaquil Specie to store common natural stats of every {'abilities': ['blaze', 'flash-fire'], 'base_experience': 62, 'height': 5, 'id': 155, 'moves': ['cut', 'double-kick', 'headbutt', 'tackle', 'body-slam', 'thrash', 'double-edge', 'leer', 'ember', 'flamethrower', 'submission', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'smokescreen', 'defense-curl', 'fire-blast', 'swift', 'fury-swipes', 'rest', 'substitute', 'flame-wheel', 'snore', 'curse', 'reversal', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'heat-wave', 'will-o-wisp', 'facade', 'nature-power', 'eruption', 'secret-power', 'crush-claw', 'overheat', 'extrasensory', 'aerial-ace', 'howl', 'covet', 'natural-gift', 'flare-blitz', 'lava-plume', 'captivate', 'flame-burst', 'flame-charge', 'round', 'incinerate', 'inferno', 'fire-pledge', 'work-up', 'wild-charge', 'confide', 'burn-up'], 'name': 'cyndaquil', 'stats': {'hp': 39, 'attack': 52, 'defense': 43, 'special-attack': 60, 'special-defense': 50, 'speed': 65}, 'types': ['fire'], 'weight': 79, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'yellow', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヒノアラシ', 'roomaji': 'Hinoarashi', 'ko': '브케인', 'zh-Hant': '火球鼠', 'fr': 'Héricendre', 'de': 'Feurigel', 'es': 'Cyndaquil', 'it': 'Cyndaquil', 'en': 'Cyndaquil', 'ja': 'ヒノアラシ', 'zh-Hans': '火球鼠'}, 'genera': {'ja-Hrkt': 'ひねずみポケモン', 'ko': '불쥐포켓몬', 'zh-Hant': '火鼠寶可夢', 'fr': 'Pokémon Souris Feu', 'de': 'Feuermaus', 'es': 'Pokémon Ratón Fuego', 'it': 'Pokémon Fuocotopo', 'en': 'Fire Mouse Pokémon', 'ja': 'ひねずみポケモン', 'zh-Hans': '火鼠宝可梦'}}
	public class SpecieCyndaquil : PokemonSpecie
	{
#nullable enable
		private static SpecieCyndaquil? _instance = null;
#nullable restore
        public static SpecieCyndaquil Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCyndaquil();
                }
                return _instance;
            }
        }

		public SpecieCyndaquil() : base(
			"Cyndaquil",
			39, // HPs
			52, 43, // Attack & Defense
			60, 50, // Special Attack & Defense
			65			
		) {}
	}


	//Cyndaquil Pokemon Class
	public class Cyndaquil : Pokemon
	{

		public Cyndaquil(string nickname, int level)
		: base(
				155,
				SpecieCyndaquil.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cyndaquil(int level)
		: base(
				155,
				SpecieCyndaquil.Instance, // Pokemon Specie
				"Cyndaquil", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cyndaquil() : base(
			155,
			SpecieCyndaquil.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}