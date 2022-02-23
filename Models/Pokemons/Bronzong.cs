using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bronzong Specie to store common natural stats of every {'abilities': ['levitate', 'heatproof', 'heavy-metal'], 'base_experience': 175, 'height': 13, 'id': 437, 'moves': ['tackle', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'toxic', 'confusion', 'psychic', 'hypnosis', 'double-team', 'confuse-ray', 'light-screen', 'reflect', 'dream-eater', 'flash', 'psywave', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'feint-attack', 'sandstorm', 'endure', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'rock-smash', 'facade', 'trick', 'recycle', 'skill-swap', 'imprison', 'secret-power', 'rock-tomb', 'metal-sound', 'signal-beam', 'extrasensory', 'iron-defense', 'block', 'calm-mind', 'gravity', 'gyro-ball', 'natural-gift', 'payback', 'heal-block', 'rock-polish', 'giga-impact', 'zen-headbutt', 'flash-cannon', 'trick-room', 'iron-head', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'heavy-slam', 'round', 'bulldoze', 'confide'], 'name': 'bronzong', 'stats': {'hp': 67, 'attack': 89, 'defense': 116, 'special-attack': 79, 'special-defense': 116, 'speed': 33}, 'types': ['steel', 'psychic'], 'weight': 1870, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 90, 'color': 'green', 'shape': 'arms', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ドータクン', 'roomaji': 'Dotakun', 'ko': '동탁군', 'zh-Hant': '青銅鐘', 'fr': 'Archéodong', 'de': 'Bronzong', 'es': 'Bronzong', 'it': 'Bronzong', 'en': 'Bronzong', 'ja': 'ドータクン', 'zh-Hans': '青铜钟'}, 'genera': {'ja-Hrkt': 'どうたくポケモン', 'ko': '동탁포켓몬', 'zh-Hant': '銅鐘寶可夢', 'fr': 'Pokémon Clochebronze', 'de': 'Bronzeglocke', 'es': 'Pokémon Cam. Bronce', 'it': 'Pokémon Squibronzo', 'en': 'Bronze Bell Pokémon', 'ja': 'どうたくポケモン', 'zh-Hans': '铜钟宝可梦'}}
	public class SpecieBronzong : PokemonSpecie
	{
#nullable enable
		private static SpecieBronzong? _instance = null;
#nullable restore
        public static SpecieBronzong Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBronzong();
                }
                return _instance;
            }
        }

		public SpecieBronzong() : base(
			"Bronzong",
			67, // HPs
			89, 116, // Attack & Defense
			79, 116, // Special Attack & Defense
			33			
		) {}
	}


	//Bronzong Pokemon Class
	public class Bronzong : Pokemon
	{

		public Bronzong(string nickname, int level) : base(
			437,
			SpecieBronzong.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance, Psychic.Instance			
		) {}

		public Bronzong() : base(
			437,
			SpecieBronzong.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
	}
}