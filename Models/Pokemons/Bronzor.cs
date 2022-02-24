using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bronzor Specie to store common natural stats of every {'abilities': ['levitate', 'heatproof', 'heavy-metal'], 'base_experience': 60, 'height': 5, 'id': 436, 'moves': ['tackle', 'solar-beam', 'earthquake', 'toxic', 'confusion', 'psychic', 'hypnosis', 'double-team', 'confuse-ray', 'light-screen', 'reflect', 'dream-eater', 'flash', 'psywave', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'feint-attack', 'sandstorm', 'endure', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'facade', 'trick', 'recycle', 'skill-swap', 'imprison', 'secret-power', 'rock-tomb', 'metal-sound', 'signal-beam', 'extrasensory', 'iron-defense', 'calm-mind', 'gravity', 'gyro-ball', 'natural-gift', 'payback', 'heal-block', 'rock-polish', 'flash-cannon', 'trick-room', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'heavy-slam', 'round', 'bulldoze', 'confide'], 'name': 'bronzor', 'stats': {'hp': 57, 'attack': 24, 'defense': 86, 'special-attack': 24, 'special-defense': 86, 'speed': 23}, 'types': ['steel', 'psychic'], 'weight': 605, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 255, 'color': 'green', 'shape': 'ball', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ドーミラー', 'roomaji': 'Domirror', 'ko': '동미러', 'zh-Hant': '銅鏡怪', 'fr': 'Archéomire', 'de': 'Bronzel', 'es': 'Bronzor', 'it': 'Bronzor', 'en': 'Bronzor', 'ja': 'ドーミラー', 'zh-Hans': '铜镜怪'}, 'genera': {'ja-Hrkt': 'せいどうポケモン', 'ko': '청동포켓몬', 'zh-Hant': '青銅寶可夢', 'fr': 'Pokémon Bronze', 'de': 'Bronze', 'es': 'Pokémon Bronce', 'it': 'Pokémon Bronzo', 'en': 'Bronze Pokémon', 'ja': 'せいどうポケモン', 'zh-Hans': '青铜宝可梦'}}
	public class SpecieBronzor : PokemonSpecie
	{
#nullable enable
		private static SpecieBronzor? _instance = null;
#nullable restore
        public static SpecieBronzor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBronzor();
                }
                return _instance;
            }
        }

		public SpecieBronzor() : base(
			"Bronzor",
			57, // HPs
			24, 86, // Attack & Defense
			24, 86, // Special Attack & Defense
			23			
		) {}
	}


	//Bronzor Pokemon Class
	public class Bronzor : Pokemon
	{

		public Bronzor(string nickname, int level)
		: base(
				436,
				SpecieBronzor.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bronzor(int level)
		: base(
				436,
				SpecieBronzor.Instance, // Pokemon Specie
				"Bronzor", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bronzor() : base(
			436,
			SpecieBronzor.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
	}
}