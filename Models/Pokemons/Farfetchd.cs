using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Farfetchd Specie to store common natural stats of every {'abilities': ['keen-eye', 'inner-focus', 'defiant'], 'base_experience': 132, 'height': 8, 'id': 83, 'moves': ['razor-wind', 'swords-dance', 'cut', 'gust', 'whirlwind', 'fly', 'sand-attack', 'headbutt', 'fury-attack', 'body-slam', 'take-down', 'double-edge', 'leer', 'peck', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'mirror-move', 'swift', 'skull-bash', 'sky-attack', 'rest', 'slash', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'twister', 'sunny-day', 'psych-up', 'uproar', 'heat-wave', 'facade', 'helping-hand', 'revenge', 'knock-off', 'secret-power', 'feather-dance', 'air-cutter', 'aerial-ace', 'covet', 'leaf-blade', 'roost', 'natural-gift', 'feint', 'pluck', 'tailwind', 'u-turn', 'trump-card', 'last-resort', 'poison-jab', 'night-slash', 'air-slash', 'brave-bird', 'defog', 'captivate', 'ominous-wind', 'simple-beam', 'round', 'acrobatics', 'retaliate', 'final-gambit', 'work-up', 'confide', 'first-impression', 'brutal-swing'], 'name': 'farfetchd', 'stats': {'hp': 52, 'attack': 90, 'defense': 55, 'special-attack': 58, 'special-defense': 62, 'speed': 60}, 'types': ['normal', 'flying'], 'weight': 150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'wings', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['flying', 'ground'], 'names': {'ja-Hrkt': 'カモネギ', 'roomaji': 'Kamonegi', 'ko': '파오리', 'zh-Hant': '大蔥鴨', 'fr': 'Canarticho', 'de': 'Porenta', 'es': "Farfetch'd", 'it': "Farfetch'd", 'en': "Farfetch'd", 'ja': 'カモネギ', 'zh-Hans': '大葱鸭'}, 'genera': {'ja-Hrkt': 'かるがもポケモン', 'ko': '천둥오리포켓몬', 'zh-Hant': '黃嘴鴨寶可夢', 'fr': 'Pokémon Canard Fou', 'de': 'Wildente', 'es': 'Pokémon Pato Salvaje', 'it': 'Pokémon Selvanatra', 'en': 'Wild Duck Pokémon', 'ja': 'かるがもポケモン', 'zh-Hans': '黄嘴鸭宝可梦'}}
	public class SpecieFarfetchd : PokemonSpecie
	{
#nullable enable
		private static SpecieFarfetchd? _instance = null;
#nullable restore
        public static SpecieFarfetchd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFarfetchd();
                }
                return _instance;
            }
        }

		public SpecieFarfetchd() : base(
			"Farfetchd",
			52, // HPs
			90, 55, // Attack & Defense
			58, 62, // Special Attack & Defense
			60			
		) {}
	}


	//Farfetchd Pokemon Class
	public class Farfetchd : Pokemon
	{

		public Farfetchd(string nickname, int level) : base(
			83,
			SpecieFarfetchd.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Farfetchd() : base(
			83,
			SpecieFarfetchd.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}