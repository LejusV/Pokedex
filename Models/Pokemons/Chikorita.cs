using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chikorita Specie to store common natural stats of every {'abilities': ['overgrow', 'leaf-guard'], 'base_experience': 64, 'height': 9, 'id': 152, 'moves': ['swords-dance', 'cut', 'vine-whip', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'growl', 'counter', 'leech-seed', 'razor-leaf', 'solar-beam', 'poison-powder', 'toxic', 'mimic', 'double-team', 'light-screen', 'reflect', 'flash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'detect', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'ancient-power', 'facade', 'nature-power', 'ingrain', 'magic-coat', 'refresh', 'secret-power', 'aromatherapy', 'grass-whistle', 'bullet-seed', 'magical-leaf', 'natural-gift', 'wring-out', 'worry-seed', 'seed-bomb', 'energy-ball', 'leaf-storm', 'captivate', 'grass-knot', 'round', 'echoed-voice', 'heal-pulse', 'grass-pledge', 'work-up', 'grassy-terrain', 'confide'], 'name': 'chikorita', 'stats': {'hp': 45, 'attack': 49, 'defense': 65, 'special-attack': 49, 'special-defense': 65, 'speed': 45}, 'types': ['grass'], 'weight': 64, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'チコリータ', 'roomaji': 'Chicorita', 'ko': '치코리타', 'zh-Hant': '菊草葉', 'fr': 'Germignon', 'de': 'Endivie', 'es': 'Chikorita', 'it': 'Chikorita', 'en': 'Chikorita', 'ja': 'チコリータ', 'zh-Hans': '菊草叶'}, 'genera': {'ja-Hrkt': 'はっぱポケモン', 'ko': '잎사귀포켓몬', 'zh-Hant': '葉子寶可夢', 'fr': 'Pokémon Feuille', 'de': 'Laub', 'es': 'Pokémon Hoja', 'it': 'Pokémon Foglia', 'en': 'Leaf Pokémon', 'ja': 'はっぱポケモン', 'zh-Hans': '叶子宝可梦'}}
	public class SpecieChikorita : PokemonSpecie
	{
#nullable enable
		private static SpecieChikorita? _instance = null;
#nullable restore
        public static SpecieChikorita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChikorita();
                }
                return _instance;
            }
        }

		public SpecieChikorita() : base(
			"Chikorita",
			45, // HPs
			49, 65, // Attack & Defense
			49, 65, // Special Attack & Defense
			45			
		) {}
	}


	//Chikorita Pokemon Class
	public class Chikorita : Pokemon
	{

		public Chikorita(string nickname, int level)
		: base(
				152,
				SpecieChikorita.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Chikorita() : base(
			152,
			SpecieChikorita.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}