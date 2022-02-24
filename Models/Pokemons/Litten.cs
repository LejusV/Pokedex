using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Litten Specie to store common natural stats of every {'abilities': ['blaze', 'intimidate'], 'base_experience': 64, 'height': 4, 'id': 725, 'moves': ['scratch', 'swords-dance', 'double-kick', 'body-slam', 'thrash', 'leer', 'bite', 'growl', 'roar', 'ember', 'flamethrower', 'toxic', 'double-team', 'lick', 'fire-blast', 'leech-life', 'fury-swipes', 'rest', 'substitute', 'protect', 'scary-face', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'crunch', 'fake-out', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'taunt', 'revenge', 'overheat', 'bulk-up', 'u-turn', 'flare-blitz', 'nasty-plot', 'shadow-claw', 'fire-fang', 'flame-charge', 'round', 'acrobatics', 'fire-pledge', 'work-up', 'confide', 'power-trip'], 'name': 'litten', 'stats': {'hp': 45, 'attack': 65, 'defense': 40, 'special-attack': 60, 'special-defense': 40, 'speed': 70}, 'types': ['fire'], 'weight': 43, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ニャビー', 'ko': '냐오불', 'zh-Hant': '火斑喵', 'fr': 'Flamiaou', 'de': 'Flamiau', 'es': 'Litten', 'it': 'Litten', 'en': 'Litten', 'ja': 'ニャビー', 'zh-Hans': '火斑喵'}, 'genera': {'ja-Hrkt': 'ひねこポケモン', 'ko': '불고양이포켓몬', 'zh-Hant': '火貓寶可夢', 'fr': 'Pokémon Chat Feu', 'de': 'Feuerkatze', 'es': 'Pokémon Gato Fuego', 'it': 'Pokémon Pirofelino', 'en': 'Fire Cat Pokémon', 'ja': 'ひねこポケモン', 'zh-Hans': '火猫宝可梦'}}
	public class SpecieLitten : PokemonSpecie
	{
#nullable enable
		private static SpecieLitten? _instance = null;
#nullable restore
        public static SpecieLitten Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLitten();
                }
                return _instance;
            }
        }

		public SpecieLitten() : base(
			"Litten",
			45, // HPs
			65, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			70			
		) {}
	}


	//Litten Pokemon Class
	public class Litten : Pokemon
	{

		public Litten(string nickname, int level)
		: base(
				725,
				SpecieLitten.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Litten() : base(
			725,
			SpecieLitten.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}