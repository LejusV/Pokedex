using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Excadrill Specie to store common natural stats of every {'abilities': ['sand-rush', 'sand-force', 'mold-breaker'], 'base_experience': 178, 'height': 7, 'id': 530, 'moves': ['scratch', 'swords-dance', 'cut', 'horn-drill', 'hyper-beam', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'double-team', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'metal-claw', 'hidden-power', 'rock-smash', 'facade', 'brick-break', 'secret-power', 'mud-sport', 'rock-tomb', 'aerial-ace', 'iron-defense', 'fling', 'magnet-rise', 'poison-jab', 'x-scissor', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'iron-head', 'stealth-rock', 'hone-claws', 'round', 'bulldoze', 'drill-run', 'rototiller', 'confide', 'smart-strike', 'brutal-swing'], 'name': 'excadrill', 'stats': {'hp': 110, 'attack': 135, 'defense': 60, 'special-attack': 50, 'special-defense': 65, 'speed': 88}, 'types': ['ground', 'steel'], 'weight': 404, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'gray', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ドリュウズ', 'ko': '몰드류', 'zh-Hant': '龍頭地鼠', 'fr': 'Minotaupe', 'de': 'Stalobor', 'es': 'Excadrill', 'it': 'Excadrill', 'en': 'Excadrill', 'ja': 'ドリュウズ', 'zh-Hans': '龙头地鼠'}, 'genera': {'ja-Hrkt': 'ちていポケモン', 'ko': '땅밑포켓몬', 'zh-Hant': '地底寶可夢', 'fr': 'Pokémon Souterrain', 'de': 'Untergrund', 'es': 'Pokémon Subterráneo', 'it': 'Pokémon Sottoterra', 'en': 'Subterrene Pokémon', 'ja': 'ちていポケモン', 'zh-Hans': '地底宝可梦'}}
	public class SpecieExcadrill : PokemonSpecie
	{
#nullable enable
		private static SpecieExcadrill? _instance = null;
#nullable restore
        public static SpecieExcadrill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieExcadrill();
                }
                return _instance;
            }
        }

		public SpecieExcadrill() : base(
			"Excadrill",
			110, // HPs
			135, 60, // Attack & Defense
			50, 65, // Special Attack & Defense
			88			
		) {}
	}


	//Excadrill Pokemon Class
	public class Excadrill : Pokemon
	{

		public Excadrill(string nickname, int level)
		: base(
				530,
				SpecieExcadrill.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Excadrill() : base(
			530,
			SpecieExcadrill.Instance, // Pokemon Specie
			Ground.Instance, Steel.Instance			
		) {}
	}
}