using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rockruff Specie to store common natural stats of every {'abilities': ['keen-eye', 'vital-spirit', 'steadfast'], 'base_experience': 56, 'height': 5, 'id': 744, 'moves': ['sand-attack', 'tackle', 'thrash', 'leer', 'bite', 'roar', 'rock-throw', 'toxic', 'double-team', 'rest', 'rock-slide', 'substitute', 'protect', 'scary-face', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'crunch', 'facade', 'taunt', 'crush-claw', 'odor-sleuth', 'rock-tomb', 'howl', 'sucker-punch', 'rock-polish', 'thunder-fang', 'fire-fang', 'rock-climb', 'stone-edge', 'stealth-rock', 'round', 'echoed-voice', 'snarl', 'confide'], 'name': 'rockruff', 'stats': {'hp': 45, 'attack': 65, 'defense': 40, 'special-attack': 30, 'special-defense': 40, 'speed': 60}, 'types': ['rock'], 'weight': 92, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 190, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'イワンコ', 'ko': '암멍이', 'zh-Hant': '岩狗狗', 'fr': 'Rocabot', 'de': 'Wuffels', 'es': 'Rockruff', 'it': 'Rockruff', 'en': 'Rockruff', 'ja': 'イワンコ', 'zh-Hans': '岩狗狗'}, 'genera': {'ja-Hrkt': 'こいぬポケモン', 'ko': '강아지포켓몬', 'zh-Hant': '小狗寶可夢', 'fr': 'Pokémon Chiot', 'de': 'Hund', 'es': 'Pokémon Perrito', 'it': 'Pokémon Cagnolino', 'en': 'Puppy Pokémon', 'ja': 'こいぬポケモン', 'zh-Hans': '小狗宝可梦'}}
	public class SpecieRockruff : PokemonSpecie
	{
#nullable enable
		private static SpecieRockruff? _instance = null;
#nullable restore
        public static SpecieRockruff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRockruff();
                }
                return _instance;
            }
        }

		public SpecieRockruff() : base(
			"Rockruff",
			45, // HPs
			65, 40, // Attack & Defense
			30, 40, // Special Attack & Defense
			60			
		) {}
	}


	//Rockruff Pokemon Class
	public class Rockruff : Pokemon
	{

		public Rockruff(string nickname, int level)
		: base(
				744,
				SpecieRockruff.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rockruff() : base(
			744,
			SpecieRockruff.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}