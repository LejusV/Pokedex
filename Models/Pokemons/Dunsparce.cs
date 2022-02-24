using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dunsparce Specie to store common natural stats of every {'abilities': ['serene-grace', 'run-away', 'rattled'], 'base_experience': 145, 'height': 15, 'id': 206, 'moves': ['bind', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'bite', 'flamethrower', 'ice-beam', 'blizzard', 'counter', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'dig', 'toxic', 'agility', 'rage', 'mimic', 'screech', 'double-team', 'defense-curl', 'bide', 'fire-blast', 'glare', 'dream-eater', 'rest', 'rock-slide', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'flail', 'spite', 'protect', 'mud-slap', 'zap-cannon', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'rock-smash', 'facade', 'magic-coat', 'yawn', 'endeavor', 'secret-power', 'astonish', 'rock-tomb', 'calm-mind', 'shock-wave', 'water-pulse', 'roost', 'gyro-ball', 'natural-gift', 'trump-card', 'last-resort', 'poison-jab', 'aqua-tail', 'air-slash', 'dragon-rush', 'zen-headbutt', 'captivate', 'stealth-rock', 'charge-beam', 'coil', 'round', 'hex', 'incinerate', 'retaliate', 'bulldoze', 'wild-charge', 'drill-run', 'confide'], 'name': 'dunsparce', 'stats': {'hp': 100, 'attack': 70, 'defense': 70, 'special-attack': 65, 'special-defense': 65, 'speed': 45}, 'types': ['normal'], 'weight': 140, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'squiggle', 'habitat': 'cave', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ノコッチ', 'roomaji': 'Nokocchi', 'ko': '노고치', 'zh-Hant': '土龍弟弟', 'fr': 'Insolourdo', 'de': 'Dummisel', 'es': 'Dunsparce', 'it': 'Dunsparce', 'en': 'Dunsparce', 'ja': 'ノコッチ', 'zh-Hans': '土龙弟弟'}, 'genera': {'ja-Hrkt': 'つちへびポケモン', 'ko': '땅뱀포켓몬', 'zh-Hant': '地蛇寶可夢', 'fr': 'Pokémon Serpent', 'de': 'Schlange', 'es': 'Pokémon Serptierra', 'it': 'Pokémon Terraserpe', 'en': 'Land Snake Pokémon', 'ja': 'つちへびポケモン', 'zh-Hans': '地蛇宝可梦'}}
	public class SpecieDunsparce : PokemonSpecie
	{
#nullable enable
		private static SpecieDunsparce? _instance = null;
#nullable restore
        public static SpecieDunsparce Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDunsparce();
                }
                return _instance;
            }
        }

		public SpecieDunsparce() : base(
			"Dunsparce",
			100, // HPs
			70, 70, // Attack & Defense
			65, 65, // Special Attack & Defense
			45			
		) {}
	}


	//Dunsparce Pokemon Class
	public class Dunsparce : Pokemon
	{

		public Dunsparce(string nickname, int level)
		: base(
				206,
				SpecieDunsparce.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dunsparce(int level)
		: base(
				206,
				SpecieDunsparce.Instance, // Pokemon Specie
				"Dunsparce", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dunsparce() : base(
			206,
			SpecieDunsparce.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}