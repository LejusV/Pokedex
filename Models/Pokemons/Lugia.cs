using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lugia Specie to store common natural stats of every {'abilities': ['pressure', 'multiscale'], 'base_experience': 306, 'height': 52, 'id': 249, 'moves': ['gust', 'whirlwind', 'fly', 'headbutt', 'body-slam', 'double-edge', 'roar', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'waterfall', 'swift', 'dream-eater', 'sky-attack', 'flash', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'aeroblast', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'rock-smash', 'whirlpool', 'hail', 'facade', 'trick', 'skill-swap', 'secret-power', 'dive', 'hyper-voice', 'weather-ball', 'air-cutter', 'signal-beam', 'extrasensory', 'aerial-ace', 'calm-mind', 'shock-wave', 'water-pulse', 'roost', 'brine', 'natural-gift', 'tailwind', 'punishment', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'earth-power', 'giga-impact', 'avalanche', 'zen-headbutt', 'defog', 'iron-head', 'charge-beam', 'ominous-wind', 'wonder-room', 'psyshock', 'telekinesis', 'round', 'echoed-voice', 'sky-drop', 'bulldoze', 'dragon-tail', 'confide'], 'name': 'lugia', 'stats': {'hp': 106, 'attack': 90, 'defense': 130, 'special-attack': 90, 'special-defense': 154, 'speed': 110}, 'types': ['psychic', 'flying'], 'weight': 2160, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'white', 'shape': 'wings', 'habitat': 'rare', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ルギア', 'roomaji': 'Lugia', 'ko': '루기아', 'zh-Hant': '洛奇亞', 'fr': 'Lugia', 'de': 'Lugia', 'es': 'Lugia', 'it': 'Lugia', 'en': 'Lugia', 'ja': 'ルギア', 'zh-Hans': '洛奇亚'}, 'genera': {'ja-Hrkt': 'せんすいポケモン', 'ko': '잠수포켓몬', 'zh-Hant': '潛水寶可夢', 'fr': 'Pokémon Plongeon', 'de': 'Taucher', 'es': 'Pokémon Buceo', 'it': 'Pokémon Immersione', 'en': 'Diving Pokémon', 'ja': 'せんすいポケモン', 'zh-Hans': '潜水宝可梦'}}
	public class SpecieLugia : PokemonSpecie
	{
#nullable enable
		private static SpecieLugia? _instance = null;
#nullable restore
        public static SpecieLugia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLugia();
                }
                return _instance;
            }
        }

		public SpecieLugia() : base(
			"Lugia",
			106, // HPs
			90, 130, // Attack & Defense
			90, 154, // Special Attack & Defense
			110			
		) {}
	}


	//Lugia Pokemon Class
	public class Lugia : Pokemon
	{

		public Lugia(string nickname, int level)
		: base(
				249,
				SpecieLugia.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lugia() : base(
			249,
			SpecieLugia.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
	}
}