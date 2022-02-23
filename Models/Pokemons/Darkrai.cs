using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Darkrai Specie to store common natural stats of every {'abilities': ['bad-dreams'], 'base_experience': 270, 'height': 15, 'id': 491, 'moves': ['swords-dance', 'cut', 'headbutt', 'disable', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'hypnosis', 'quick-attack', 'night-shade', 'double-team', 'haze', 'swift', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'nightmare', 'snore', 'spite', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'trick', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'aerial-ace', 'calm-mind', 'shock-wave', 'natural-gift', 'payback', 'embargo', 'fling', 'last-resort', 'sucker-punch', 'poison-jab', 'dark-pulse', 'x-scissor', 'drain-punch', 'focus-blast', 'giga-impact', 'nasty-plot', 'shadow-claw', 'rock-climb', 'charge-beam', 'dark-void', 'ominous-wind', 'wonder-room', 'foul-play', 'round', 'incinerate', 'retaliate', 'snarl', 'confide', 'power-up-punch'], 'name': 'darkrai', 'stats': {'hp': 70, 'attack': 90, 'defense': 90, 'special-attack': 135, 'special-defense': 90, 'speed': 125}, 'types': ['dark'], 'weight': 505, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'black', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ダークライ', 'roomaji': 'Darkrai', 'ko': '다크라이', 'zh-Hant': '達克萊伊', 'fr': 'Darkrai', 'de': 'Darkrai', 'es': 'Darkrai', 'it': 'Darkrai', 'en': 'Darkrai', 'ja': 'ダークライ', 'zh-Hans': '达克莱伊'}, 'genera': {'ja-Hrkt': 'あんこくポケモン', 'ko': '암흑포켓몬', 'zh-Hant': '暗黑寶可夢', 'fr': 'Pokémon Noirtotal', 'de': 'Dunkelnacht', 'es': 'Pokémon Oscuridad', 'it': 'Pokémon Neropesto', 'en': 'Pitch-Black Pokémon', 'ja': 'あんこくポケモン', 'zh-Hans': '暗黑宝可梦'}}
	public class SpecieDarkrai : PokemonSpecie
	{
#nullable enable
		private static SpecieDarkrai? _instance = null;
#nullable restore
        public static SpecieDarkrai Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDarkrai();
                }
                return _instance;
            }
        }

		public SpecieDarkrai() : base(
			"Darkrai",
			70, // HPs
			90, 90, // Attack & Defense
			135, 90, // Special Attack & Defense
			125			
		) {}
	}


	//Darkrai Pokemon Class
	public class Darkrai : Pokemon
	{

		public Darkrai(string nickname, int level) : base(
			491,
			SpecieDarkrai.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance			
		) {}

		public Darkrai() : base(
			491,
			SpecieDarkrai.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}