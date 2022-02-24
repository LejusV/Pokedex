using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Musharna Specie to store common natural stats of every {'abilities': ['forewarn', 'synchronize', 'telepathy'], 'base_experience': 170, 'height': 11, 'id': 518, 'moves': ['psybeam', 'hyper-beam', 'thunder-wave', 'toxic', 'psychic', 'hypnosis', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'torment', 'facade', 'helping-hand', 'trick', 'magic-coat', 'skill-swap', 'secret-power', 'rock-tomb', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'gyro-ball', 'lucky-chant', 'worry-seed', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'after-you', 'round', 'confide', 'dazzling-gleam', 'psychic-terrain'], 'name': 'musharna', 'stats': {'hp': 116, 'attack': 55, 'defense': 85, 'special-attack': 107, 'special-defense': 95, 'speed': 29}, 'types': ['psychic'], 'weight': 605, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 75, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ムシャーナ', 'ko': '몽얌나', 'zh-Hant': '夢夢蝕', 'fr': 'Mushana', 'de': 'Somnivora', 'es': 'Musharna', 'it': 'Musharna', 'en': 'Musharna', 'ja': 'ムシャーナ', 'zh-Hans': '梦梦蚀'}, 'genera': {'ja-Hrkt': 'ゆめうつつポケモン', 'ko': '꿈결포켓몬', 'zh-Hant': '半夢半醒寶可夢', 'fr': 'Pokémon Rêveur', 'de': 'Halbschlaf', 'es': 'Pokémon Duermevela', 'it': 'Pokémon Dormiveglia', 'en': 'Drowsing Pokémon', 'ja': 'ゆめうつつポケモン', 'zh-Hans': '半梦半醒宝可梦'}}
	public class SpecieMusharna : PokemonSpecie
	{
#nullable enable
		private static SpecieMusharna? _instance = null;
#nullable restore
        public static SpecieMusharna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMusharna();
                }
                return _instance;
            }
        }

		public SpecieMusharna() : base(
			"Musharna",
			116, // HPs
			55, 85, // Attack & Defense
			107, 95, // Special Attack & Defense
			29			
		) {}
	}


	//Musharna Pokemon Class
	public class Musharna : Pokemon
	{

		public Musharna(string nickname, int level)
		: base(
				518,
				SpecieMusharna.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Musharna() : base(
			518,
			SpecieMusharna.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}