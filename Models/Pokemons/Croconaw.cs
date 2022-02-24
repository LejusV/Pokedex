using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Croconaw Specie to store common natural stats of every {'abilities': ['torrent', 'sheer-force'], 'base_experience': 142, 'height': 11, 'id': 159, 'moves': ['mega-punch', 'ice-punch', 'scratch', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'thrash', 'double-edge', 'leer', 'bite', 'roar', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'low-kick', 'counter', 'seismic-toss', 'strength', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'waterfall', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'flail', 'spite', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'detect', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'facade', 'focus-punch', 'superpower', 'brick-break', 'secret-power', 'dive', 'rock-tomb', 'aerial-ace', 'block', 'dragon-claw', 'water-pulse', 'natural-gift', 'fling', 'aqua-tail', 'shadow-claw', 'ice-fang', 'captivate', 'hone-claws', 'round', 'chip-away', 'scald', 'water-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'croconaw', 'stats': {'hp': 65, 'attack': 80, 'defense': 80, 'special-attack': 59, 'special-defense': 63, 'speed': 58}, 'types': ['water'], 'weight': 250, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'アリゲイツ', 'roomaji': 'Alligates', 'ko': '엘리게이', 'zh-Hant': '藍鱷', 'fr': 'Crocrodil', 'de': 'Tyracroc', 'es': 'Croconaw', 'it': 'Croconaw', 'en': 'Croconaw', 'ja': 'アリゲイツ', 'zh-Hans': '蓝鳄'}, 'genera': {'ja-Hrkt': 'おおあごポケモン', 'ko': '큰턱포켓몬', 'zh-Hant': '大顎寶可夢', 'fr': 'Pokémon Mâchoire', 'de': 'Großmaul', 'es': 'Pokémon Fauces', 'it': 'Pokémon Mascellone', 'en': 'Big Jaw Pokémon', 'ja': 'おおあごポケモン', 'zh-Hans': '大颚宝可梦'}}
	public class SpecieCroconaw : PokemonSpecie
	{
#nullable enable
		private static SpecieCroconaw? _instance = null;
#nullable restore
        public static SpecieCroconaw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCroconaw();
                }
                return _instance;
            }
        }

		public SpecieCroconaw() : base(
			"Croconaw",
			65, // HPs
			80, 80, // Attack & Defense
			59, 63, // Special Attack & Defense
			58			
		) {}
	}


	//Croconaw Pokemon Class
	public class Croconaw : Pokemon
	{

		public Croconaw(string nickname, int level)
		: base(
				159,
				SpecieCroconaw.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Croconaw(int level)
		: base(
				159,
				SpecieCroconaw.Instance, // Pokemon Specie
				"Croconaw", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Croconaw() : base(
			159,
			SpecieCroconaw.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}